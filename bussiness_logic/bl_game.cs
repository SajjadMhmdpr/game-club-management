using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using data_access;
using System.Data;

namespace bussiness_logic
{
    public class bl_game
    {
        dl_game dlg = new dl_game();

        public List<Game> readGames(bool all)
        {
            return dlg.readGames(all);
        }
        public List<Game> readGamesForChoosePage()
        {
            return dlg.readGamesForChoosePage();
        }

            public List<Desk> readDesks(string s)
        {
            return dlg.readDesks(s);
        }

        public List<Desk> readDesks(int gameID)
        {
            return dlg.readDesks(gameID);
        }


        public void deleteDesk(int id)
        {
            dlg.deleteDesk(id);
        }

        public void deleteGame(int id)
        {
            dlg.deleteGame(id);
        }

        public Game searchGame(int id)
        {
            return dlg.searchGame(id);
        }
        public Desk searchDesk(int id)
        {
            return dlg.searchDesk(id);
        }

        public bool addDesk(string name, int idG)
        {
            return dlg.addDesk(name, idG);
        }
        public bool addGame(Game game)
        {
            return dlg.addGame(game);
        }
        public void updateGame(Game game)
        {
            dlg.updateGame(game);
        }

        public List<string> getSelectedGameDesks(List<string> games)
        {
            return dlg.getSelectedGameDesks(games);
        }
    }
}
