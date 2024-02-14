using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace data_access
{
    public class dl_player
    {
        DB db = new DB();


        public bool addPlayer(Player p)
        {
            if (searchTel(p.plPhone))
                return false;

            db.Players.Add(p);

            db.SaveChanges();

            return true;
        }

        public bool chekActiveGame(int plID)
        {
            var q5 = from i in db.Historys.Include("player")
                     where i.player.id == plID && i.endTime == "0" select i;
            
            if (q5.Count() > 0)
                return true;

            return false; 
        }

        public void startGame(int plID , string ac , string de , int c,int hiID)
        {
            var q1 = from i in db.Players where i.id == plID select i;
            Player player = q1.Single();
            var q2 = from i in db.Games where i.acState2 && i.acState && i.acName == ac  select i;
            Game game = q2.Single();
            var q3 = from i in db.Desks where i.deState2 && i.deState && i.deskCode == de select i;
            Desk desk = q3.Single();
            var q4 = from i in db.Historys.Include("desk.deGame") where i.id == hiID select i;
            History history = q4.Single();


            history.desk = desk;
            history.setController(c);
            history.player = player;


            player.historys.Add(history);

            desk.deState = false;
            db.SaveChanges();


            DB db1 = new DB();
            var numDesk = from i in db1.Desks.Include("deGame") where i.deState2 && i.deState 
                          && i.deGame.acName == ac select i;
            var q5 = from i in db1.Games where i.acState2 && i.acName == ac select i;
            Game game2 = q5.Single();

            if (numDesk.Count() == 0)
                game2.acState = false;

            db1.SaveChanges();

        }

        public History calculatePrice(History h )
        {
            double hazineKol = 0;
            double actTime=0;

            string hour1 =h.startTime[0].ToString() + h.startTime[1].ToString();
            string min1 = h.startTime[3].ToString() + h.startTime[4].ToString();

            string hour2 = h.endTime[0].ToString() + h.endTime[1].ToString();
            string min2 = h.endTime[3].ToString() + h.endTime[4].ToString();

            double hour = (Convert.ToDouble(hour2)) - (Convert.ToDouble(hour1));
            if (hour < 0)
                hour += 24;

            actTime = hour + ( ( Convert.ToDouble(min2) - Convert.ToDouble(min1) )/60 )  ;

            hazineKol = actTime * (h.hiPrice);

            if((hazineKol%1000) >= 500)
            {
                hazineKol = (((int)hazineKol / 1000) + 1) * 1000;
            }
            else
            {
                hazineKol = (int)((hazineKol)/1000);
                hazineKol *= 1000;
            }

            h.hiHazineKol = hazineKol;
            h.activityTime = (int)(actTime*60);
           

            return h;
        }

        public void paidAllGameToday( int plid)
        {
            PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
            string todayDate = persianDate.Date.ToString("yyyy/MM/dd");


            var q2 = from i in db.Historys.Include("player")
                     where i.player.id == plid &&  i.date== todayDate && i.conPardakht==false  select i;


            foreach (var item in q2)
            {
                item.conPardakht = true;
                item.player.plHazineBedehi -= (item.hiHazineKol - item.Paid);
                item.Paid = (int)item.hiHazineKol;
                
            }

            db.SaveChanges();


        }

        public void closeGame(History h)
        {
            var q2 = from i in db.Historys.Include("desk.deGame").Include("player")
                     where i.id == h.id  select i;
            History history = q2.Single();

            history.endTime = h.endTime;
            history.hiHazineKol = h.hiHazineKol;
            history.activityTime = h.activityTime;
            history.conPardakht = false;
            history.player.plHazineBedehi += h.hiHazineKol;
            //history.conChangeGame = true;

            var q3 = from i in db.Desks
                     where i.deState2 && i.deskCode == h.desk.deskCode  select i;
            Desk desk = q3.Single();
            desk.deState = true;

            var q4 = from i in db.Games
                     where i.acState2 && !i.acState && i.acName == desk.deGame.acName  select i;
            if (q4.Count() > 0)
            {
                Game game = q4.Single();
                game.acState = true;
            }
            
            

            db.SaveChanges();

        }
        
        public void conPardakht(History H , bool conPardakht)
        {
            var q2 = from i in db.Historys.Include("player")
                     where i.id == H.id select i;
            History history = q2.Single();
            //history.conChangeGame = false;

            if (conPardakht)
                history.conPardakht = true;
            else
            {
                history.conPardakht = false;
                history.player.plHazineBedehi += history.hiHazineKol;
            }

            db.SaveChanges();
        }

        public void paidAllBedehiInAllTime(int plID)
        {
            var q = from i in db.Historys.Include("player")
                    where i.player.id == plID && i.conPardakht == false
                    select i;

            foreach (var i in q)
            {
                i.conPardakht = true;
                //i.player.plHazineBedehi -= (i.hiHazineKol - i.Paid);
                i.player.plHazineBedehi = 0;
                i.Paid = (int)i.hiHazineKol;
            }

            if (q.Count() == 0)
            {
                var q2 = from i in db.Players
                         where i.id == plID
                         select i;
                q2.Single().plHazineBedehi = 0;
            }

            db.SaveChanges();

        }

        public int productCode()
        {
            /*Random rnd = new Random((int)DateTime.Now.Ticks);
            int code;
            while (true)
            {
                code = rnd.Next(1000, 10000);
                if (!searchCode(code))
                    return code;
            }*/
            var q = from i in db.codes select i;

            if(!q.Any())
            {
                Code c = new Code();
                c.code = 1;
                db.codes.Add(c);

                db.SaveChanges();

                return c.code;
            }
            else
            {
                Code c = q.Single();
                c.code += 1;

                while (searchCode(c.code))
                {
                    c.code += 1;
                }

                db.SaveChanges();

                return c.code;
            }



        }
        
        public bool searchCode(int c)
        {
            var q = from i in db.Players where i.plCode == c select i;
            if (q.Count() > 0)
                return true;
            return false;
        }
        
        bool searchTel(string t)
        {
            var q = from i in db.Players where i.plPhone == t select i;
            if (q.Count() > 0)
                return true;
            return false;
        }

        public bool search(Player p)
        {
            var q = from i in db.Players where i.plName == p.plName select i;
            if (q.Any())
                return true;
            return false;
        }
        
        public Player search(int id)
        {
            DB db1 = new DB();
            var q = from i in db1.Players where  i.id == id select i;
            return q.Single();
        }

        public void changePlayear(int plid,int hiid)
        {
            var q1 = from i in db.Historys.Include("player")
                     where i.id == hiid  select i;
            History history = q1.Single();

            var q2 = from i in db.Players where i.id == plid select i;
            Player player = q2.Single();


            history.player.plHazineBedehi -= (history.hiHazineKol - history.Paid);

            player.plHazineBedehi += (history.hiHazineKol - history.Paid);

            history.player = player;

            db.SaveChanges();
        }

        public List<Player> read()
        {
            var q = from i in db.Players where i.plState select i;
            return db.Players.ToList();   
        }

        public DataTable searchAndShowForPlayerList(string s,bool showBedehi)
        {
            string ss = " " , code = " ";
            int n;

            if (showBedehi)
                ss = "   AND  plHazineBedehi > 0  ";

            if (s.Length > 9)
                code = "00";
            else
                code = s;

            if(!int.TryParse(code, out n))
            {
                code = "00";
            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT id, plCode, plName, plFamily, plPhone, plHazineBedehi, plState" +
                    " FROM dbo.Players where (dbo.Players.plName like N'%" + s + "%' " +
                    " or  dbo.Players.plFamily like N'%" + s + "%'  " +
                    "or  dbo.Players.plCode='" + code + "' or dbo.Players.plPhone ='" + s + "' ) AND dbo.Players.plState=1  " + ss+" ";
                adp.Fill(dt);

                return dt;
                
            }
        }

        public DataTable readAndShowForPlayerList(bool showBedehi)
        {
            string s = " ";

            if (showBedehi)
                s = "   AND  plHazineBedehi > 0  ";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT id, plCode, plName, plFamily, plPhone, plHazineBedehi, plState" +
                    " FROM dbo.Players where  dbo.Players.plState=1 " + s + "";
                adp.Fill(dt);
                return dt;
            }
        }



    }
}
