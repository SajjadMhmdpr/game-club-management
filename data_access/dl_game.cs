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
    public class dl_game
    {
        DB db = new DB();

        public List<Game> readGames(bool all)
        {
            DB db1 = new DB();

            if (!all)
            {
                var q = from i in db1.Games where i.acState2 select i;
                return q.ToList();
            }
            else
            {
                var q = from i in db1.Games select i;
                return q.ToList();
            }

            
        }
        public List<Game> readGamesForChoosePage()
        {
            DB db1 = new DB();
            var q = from i in db1.Games where i.acState2 && i.acState select i;
            return q.ToList();

        }
        public void deleteGame(int id)
        {
            var q = from i in db.Games.Include("desks") where i.id == id select i;
            Game game = q.Single();

            game.acState2 = false;
            game.acState = false;

            foreach (var i in game.desks)
            {
                i.deState = false;
                i.deState2 = false;
            }

            db.SaveChanges();
        }
        public bool addGame(Game game)
        {
            var q = from i in db.Games
                    where  i.acName == game.acName  select i;
            if (q.Count() > 0)
                return false;

            Game a = new Game();
            a.acName = game.acName;
            a.acPrice = game.acPrice;
            a.acControllerPrice = game.acControllerPrice;
            a.acState = true;
            a.acState2 = true;

            db.Games.Add(a);
            db.SaveChanges();

            return true;
        }
        public void updateGame(Game g)
        {
            /*var q = from i in db.Games.Include("desks") where i.id == g.id select i;
            Game lastGame = q.Single();
            lastGame.acState = false;
            lastGame.acState2 = false;

            Game newGame = new Game();
            newGame.acState = true;
            newGame.acState2 = true;
            newGame.acName = g.acName;
            newGame.acPrice = g.acPrice;
            newGame.acControllerPrice = g.acControllerPrice;


            for (int i = 0; i < lastGame.desks.Count(); i++)
            {
                Desk d = new Desk();

                d.deskCode = lastGame.desks[i].deskCode;
                d.deState = true;
                d.deState2 = true;

                newGame.desks.Add(d);

                lastGame.desks[i].deState = false;
                lastGame.desks[i].deState2 = false;
            }
            db.Games.Add(newGame);
            db.SaveChanges();*/

            var q = from i in db.Games.Include("desks") where i.id == g.id select i;
            Game game = q.Single();

            game.acName = g.acName;
            game.acPrice = g.acPrice;
            game.acControllerPrice = g.acControllerPrice;

            db.SaveChanges();

        }
        public Game searchGame(int id)
        {
            var q = from i in db.Games where i.id == id select i;
            /*Game a = new Game();
            a.id = id;
            a.acName = q.Single().acName;
            a.acPrice = q.Single().acPrice;
            a.acControllerPrice = q.Single().acControllerPrice;*/
            return q.Single();
        }



        //----------------------------------------------------------------------------------------------------------------------------------------



        public List<Desk> readDesks(string s)
        {
            var q = from i in db.Desks.Include("deGame")
                    where i.deState2 && i.deState && i.deGame.acName == s select i;

            if (q.Count() == 0)
            {
                Desk d = new Desk();
                d.deskCode = " ";
                List<Desk> dd = new List<Desk>();
                dd.Add(d);

                return dd;
            }
                

            return q.ToList();
        }
        public List<Desk> readDesks(int gameID)
        {
            var q = from i in db.Desks.Include("deGame")
                    where i.deState2  && i.deGame.id == gameID   select i;
            if (q.Count() == 0)
                return new List<Desk>();

            return q.ToList();
        }
        public void deleteDesk(int id)
        {
            var q = from i in db.Desks.Include("deGame") where i.id == id select i;
            Desk desk = q.Single();

            desk.deState2 = false;
            desk.deState = false;
            db.SaveChanges();

            var q2 = from i in db.Desks.Include("deGame") where 
                    i.deState2 && i.deGame.acName==desk.deGame.acName  select i;
            if (q2.Count() == 0)
            {
                desk.deGame.acState2 = false;
                desk.deGame.acState = false;
                db.SaveChanges();
            }
            



        }
        public bool addDesk(string name , int idG)
        {
            var q = from i in db.Desks.Include("deGame")
                    where i.deskCode == name  select i;
            if (q.Count() > 0)
                return false;

            var q2 = from i in db.Games where i.id == idG select i;
            Game game = q2.Single();

            Desk d = new Desk();
            d.deskCode = name;
            d.deState = true;
            d.deState2 = true;

            game.desks.Add(d);
            db.SaveChanges();

            return true;
        }
        public Desk searchDesk(int id)
        {
            var q = from i in db.Desks where i.id == id select i;
            return q.Single();
        }
        public List<string> getSelectedGameDesks(List<string> games)
        {
            List<string> desks = new List<string>();

            foreach (var i in games)
            {
                var q = from j in db.Games.Include("desks") where j.acName == i select j;

                foreach (var j in q)
                {
                    foreach (var k in j.desks)
                    {
                        desks.Add(k.deskCode);
                    }
                }
            }

            return desks;
        }
    }
}
