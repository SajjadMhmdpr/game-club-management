using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using model;



namespace data_access
{
    public class dl_history
    {
        DB db = new DB();

        public DataTable showFactor(int id , int con)
        {
            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Games.acName, dbo.Desks.deskCode,dbo.Histories.Paid, dbo.Histories.date, dbo.Histories.startTime, dbo.Histories.hiHazineKol , dbo.Histories.activityTime , dbo.Histories.controlNum , dbo.Histories.endTime, dbo.Histories.id, dbo.Employees.emName" +
                  " FROM     dbo.Games INNER JOIN " +
                  "  dbo.Desks ON dbo.Games.id = dbo.Desks.deGame_id INNER JOIN " +
                  "  dbo.Histories ON dbo.Desks.id = dbo.Histories.desk_id INNER JOIN " +
                  " dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                  " WHERE(dbo.Histories.player_id = "+id.ToString()+ ") AND (dbo.Histories.conPardakht=" + con.ToString() + ")" +
                  " AND (dbo.Histories.hiHazineKol !=0 )  ";
                adp.Fill(dt);
                return dt;
            }
        }

        public int pardakhtKolBedehi(int hiID)
        {
            var q = from i in db.Historys.Include("player")
                    where i.id == hiID   select i;
            History history = q.Single();

            history.conPardakht = true;
            history.player.plHazineBedehi -= (history.hiHazineKol - history.Paid);
            history.Paid = (int)history.hiHazineKol;
            
            
            db.SaveChanges();

            return (int)history.player.plHazineBedehi;     

        }

        public bool pardakhtNesfeOneHistory(int hiID , int amount)
        {
            var q = from i in db.Historys.Include("player")
                    where i.id == hiID  select i;
            History history = q.Single();

            if ((amount + history.Paid) > history.hiHazineKol)
                return false;

            
            history.Paid += amount;
            history.player.plHazineBedehi -= amount;

            if(history.hiHazineKol == history.Paid)
            {
                history.conPardakht = true;
            }


            db.SaveChanges();

            return true;


        }

        public History showInformationPardakht(int hiID )
        {
            string endTime = DateTime.Now.ToString("HH:mm:ss");

            var q2 = from i in db.Historys.Include("desk.deGame").Include("player").Include("employee")
                     where i.id == hiID  select i;
            History history = q2.Single();
            history.endTime = endTime;

            dl_player dlp = new dl_player();

            return dlp.calculatePrice(history);
        }

        public History searchAndReturnHistory(int hiId)
        {
            var q2 = from i in db.Historys.Include("desk.deGame").Include("player").Include("employee")
                     where i.id == hiId  select i;
            History history = q2.Single();

            return history;
        }

        public int add(int emID, string date, string start)
        {
            var employee = from i in db.Employees where i.emState &&  i.id == emID select i;

            History hi = new History();
            hi.employee = employee.Single();
            hi.date = date;
            hi.startTime = start;
            hi.endTime = "0";
            //hi.conChangeGame = true;
            hi.conPardakht = false;
            hi.Paid = 0;

            db.Historys.Add(hi);
            db.SaveChanges();

            return search(date, start);
        }

        public void delete(int hiID)
        {
            var q = from i in db.Historys.Include("player").Include("desk.deGame")
                    where i.id == hiID && i.endTime=="0" select i;
            History history = q.Single();

            history.desk.deState = true;
            history.desk.deGame.acState = true;
            db.Historys.Remove(history);
            

            db.SaveChanges();
        }
        
        public int search(string date, string start)
        {
            var hi = from i in db.Historys where i.date == date && i.startTime==start select i;
            return hi.Single().id;
        }

        public DataTable readAndShowForDarhalEjra()
        {
            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Players.plCode, dbo.Histories.id, dbo.Players.plName, dbo.Players.plFamily, dbo.Players.plPhone, dbo.Histories.startTime, dbo.Desks.deskCode ,  dbo.Histories.controlNum , dbo.Games.acName, dbo.Employees.emName" +
                  " FROM dbo.Players INNER JOIN "+
                  " dbo.Histories ON dbo.Players.id = dbo.Histories.Player_id INNER JOIN "+
                  " dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN "+
                  " dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                  " dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id "+
                  " WHERE(dbo.Histories.endTime = '0') ";
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable searchAndShowForDarhalEjra(string s)
        {
            string code = " ";
            int n;
            if (s.Length > 9)
                code = "00";
            else
                code = s;
            if (!int.TryParse(code, out n))
            {
                code = "00";
            }
            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Players.plCode, dbo.Histories.id, dbo.Players.plName, dbo.Players.plFamily, dbo.Players.plPhone, dbo.Histories.startTime,  dbo.Histories.controlNum , dbo.Desks.deskCode, dbo.Games.acName, dbo.Employees.emName" +
                  " FROM dbo.Players INNER JOIN " +
                  " dbo.Histories ON dbo.Players.id = dbo.Histories.Player_id INNER JOIN " +
                  " dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN " +
                  " dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                  " dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                  " WHERE(dbo.Histories.endTime = '0') "+
                  " and (dbo.Players.plName like N'%" + s + "%' " +
                    " or  dbo.Players.plFamily like N'%" + s + "%'  " +
                    "or  dbo.Players.plCode ='" + code + "' or  dbo.Players.plPhone='" + s + "' ) ";
                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable showGamesPlayed(int plid)
        {
            PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
            string todayDate = persianDate.Date.ToString("yyyy/MM/dd");

            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Games.acName, dbo.Desks.deskCode, dbo.Histories.Paid, dbo.Histories.startTime, dbo.Histories.hiHazineKol , dbo.Histories.activityTime , dbo.Histories.controlNum , dbo.Histories.endTime, dbo.Histories.id, dbo.Employees.emName" +
                  " FROM     dbo.Games INNER JOIN " +
                  "  dbo.Desks ON dbo.Games.id = dbo.Desks.deGame_id INNER JOIN " +
                  "  dbo.Histories ON dbo.Desks.id = dbo.Histories.desk_id INNER JOIN " +
                  " dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                  " WHERE(dbo.Histories.player_id = " + plid.ToString() + ") AND (dbo.Histories.endTime != '0' ) " +
                  "    AND (dbo.Histories.date = '"+ todayDate + "') AND (dbo.Histories.conPardakht = 0 ) ";
                //AND(dbo.Histories.conChangeGame = 1)  AND (dbo.Histories.endTime != '0' )
                adp.Fill(dt);
                return dt;
            }
        }
    
        public int calPriceFactorsInPardahktPage(int plid)
        {
            PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
            string todayDate = persianDate.Date.ToString("yyyy/MM/dd");
            DB db1 = new DB();
            int jam = 0;

            var q = from i in db1.Historys where i.player.id==plid && i.date== todayDate && i.conPardakht==false select i;

            foreach (var i in q)
            {
                jam += (int)i.hiHazineKol;
                jam -= i.Paid;
            }

            return jam;
        }

        public DataTable showAllHistory(string sdate , string edate, ref int daramad, ref int bedehi)
        {
            DateTime startDate = DateTime.Parse(sdate);
            DateTime endDate = DateTime.Parse(edate);

            foreach (var h in db.Historys)
            {
                if ( System.DateTime.Parse(h.date) >= startDate
                        && System.DateTime.Parse(h.date) <= endDate)
                {
                    if(h.conPardakht==true)
                        daramad += (int)h.hiHazineKol;
                    else
                        bedehi += (int)h.hiHazineKol;
                }
            }

            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Histories.id, dbo.Histories.date, dbo.Histories.startTime, dbo.Histories.endTime, dbo.Histories.activityTime, dbo.Histories.hiHazineKol, dbo.Desks.deskCode, dbo.Games.acName, dbo.Employees.emName, dbo.Players.plName,  " +
                "   dbo.Histories.controlNum, dbo.Players.plCode, dbo.Players.plFamily " +
                " FROM     dbo.Histories INNER JOIN " +
                "  dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN " +
                 "  dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                 " dbo.Players ON dbo.Histories.player_id = dbo.Players.id INNER JOIN " +
                 "  dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                  " WHERE(dbo.Histories.date >= '" + sdate + "' ) and (dbo.Histories.date <= '" + edate + "' )";

                adp.Fill(dt);
                return dt;
            }
        }

        public DataTable showAllHistorysWhitFilters(string sd, string ed , List<string> desks, ref int daramad, ref int bedehi)
        {
            List<int> historyID = new List<int>();

            DateTime startDate = DateTime.Parse(sd);
            DateTime endDate = DateTime.Parse(ed);
            string id = "salam";

            foreach (var desk in desks)
            {
                foreach (var h in db.Historys.Include("desk.deGame"))
                {
                    if(h.desk.deskCode == desk && System.DateTime.Parse(h.date) >= startDate 
                        && System.DateTime.Parse(h.date) <= endDate)
                    {
                        historyID.Add(h.id);
                        if (h.conPardakht == true)
                            daramad += (int)h.hiHazineKol;
                        else
                        {
                            bedehi += (int)h.hiHazineKol;
                            bedehi -= h.Paid;
                        }
                    }
                }

            }

            if (historyID.Count() > 0)
            {

                id = "";
                for (int i = 0; i < historyID.Count(); i++)
                {
                    id += historyID[i].ToString();
                    if (i < historyID.Count() - 1)
                        id += ",";
                }

                using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = new SqlCommand();
                    adp.SelectCommand.Connection = connection;
                    adp.SelectCommand.CommandText = "SELECT dbo.Histories.id, dbo.Histories.date,dbo.Histories.Paid, dbo.Histories.startTime, dbo.Histories.endTime, dbo.Histories.activityTime, dbo.Histories.hiHazineKol, dbo.Desks.deskCode, dbo.Games.acName, dbo.Employees.emName, dbo.Players.plName,  " +
                    "   dbo.Histories.controlNum, dbo.Players.plCode, dbo.Players.plFamily " +
                    " FROM     dbo.Histories INNER JOIN " +
                    "  dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN " +
                     "  dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                     " dbo.Players ON dbo.Histories.player_id = dbo.Players.id INNER JOIN " +
                     "  dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                      " WHERE dbo.Histories.id in (" + id + ") ";

                    adp.Fill(dt);
                    return dt;
                }
            }

            return new DataTable();
        }

        public DataTable showAllBedehi()
        {
            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Histories.id, dbo.Histories.date, dbo.Histories.startTime, dbo.Histories.endTime, dbo.Histories.activityTime, dbo.Histories.hiHazineKol, dbo.Desks.deskCode, dbo.Games.acName, dbo.Employees.emName, dbo.Players.plName,  " +
                "   dbo.Histories.controlNum, dbo.Players.plCode, dbo.Players.plFamily " +
                " FROM     dbo.Histories INNER JOIN " +
                "  dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN " +
                 "  dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                 " dbo.Players ON dbo.Histories.player_id = dbo.Players.id INNER JOIN " +
                 "  dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                  " WHERE dbo.Histories.conPardakht=1 ";

                adp.Fill(dt);
                return dt;
            }
        }





        public DataTable showAndSearchInDayliHistory(string s , bool pardakhtSHod , bool pardakhtNashod, bool darEjra)
        {
            //PersianDateTime persianDate = new PersianDateTime(DateTime.Now);

            //string date = persianDate.Date.ToString();

            PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
            string date = persianDate.Date.ToString("yyyy/MM/dd");


            string query = " and dbo.Histories.endTime != '0' ";

            if(pardakhtNashod && pardakhtSHod)
            {
                query = " and dbo.Histories.endTime != '0' ";
            }
            else if(pardakhtNashod)
            {
                query = " and dbo.Histories.conPardakht=0 and dbo.Histories.endTime != '0' ";
            }
            else if (pardakhtSHod)
            {
                query = " and dbo.Histories.conPardakht=1 ";
            }


            if(darEjra)
            {
                query = " and dbo.Histories.endTime='0' ";
            }


            string code = " ";
            int n;
            if (s.Length > 9)
                code = "00";
            else
                code = s;
            if (!int.TryParse(code, out n))
            {
                code = "00";
            }


            using (SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GameNet"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = connection;
                adp.SelectCommand.CommandText = "SELECT dbo.Histories.id, dbo.Histories.Paid, dbo.Histories.date, dbo.Histories.startTime, dbo.Histories.endTime, dbo.Histories.activityTime, dbo.Histories.hiHazineKol, dbo.Desks.deskCode, dbo.Games.acName, dbo.Employees.emName, dbo.Players.plName,  " +
                    "   dbo.Histories.controlNum, dbo.Players.plCode, dbo.Players.plFamily ,dbo.Players.plPhone  " +
                    " FROM     dbo.Histories INNER JOIN " +
                    "  dbo.Desks ON dbo.Histories.desk_id = dbo.Desks.id INNER JOIN " +
                     "  dbo.Games ON dbo.Desks.deGame_id = dbo.Games.id INNER JOIN " +
                     " dbo.Players ON dbo.Histories.player_id = dbo.Players.id INNER JOIN " +
                     "  dbo.Employees ON dbo.Histories.employee_id = dbo.Employees.id " +
                      " WHERE dbo.Histories.date= Convert(varchar(30), '" + date + "', 112)  and (dbo.Players.plName like N'%" + s + "%' or dbo.Players.plCode = " + code + "   " +
                      " or dbo.Players.plFamily like N'%" + s + "%' or dbo.Players.plPhone='" + s + "' ) " + query ;

                adp.Fill(dt);
                return dt;
            }
        }

    }
}
