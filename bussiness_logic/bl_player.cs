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
    public class bl_player
    {
        dl_player dlp = new dl_player();

        public bool addPlayer(Player p)
        {
            return dlp.addPlayer(p);
        }

        public int productCode()
        {
            return dlp.productCode();
        }

        public List<Player> read()
        {
            return dlp.read();
        }

        public DataTable searchAndShowForPlayerList(string s, bool showBedehi)
        {
            return dlp.searchAndShowForPlayerList(s, showBedehi);
        }
        public DataTable readAndShowForPlayerList(bool showBedehi)
        {
            return dlp.readAndShowForPlayerList(showBedehi);
        }

        public Player search(int id)
        {
            return dlp.search(id);
        }

        public void startGame(int plID, string ac, string de, int c, int hiID)
        {
            dlp.startGame(plID, ac, de, c, hiID);
        }

        public bool chekActiveGame(int plID)
        {
            return dlp.chekActiveGame(plID);
        }

        public void paidAllGameToday(int plid)
        {
            dlp.paidAllGameToday(plid);
        }

        public void closeGame(History h)
        {
            dlp.closeGame(h);
        }

        public void conPardakht(History H, bool conPardakht)
        {
            dlp.conPardakht(H, conPardakht);
        }

        public void paidAllBedehiInAllTime(int plID)
        {
            dlp.paidAllBedehiInAllTime(plID);
        }
        public bool searchCode(int c)
        {
            return dlp.searchCode(c);
        }

        public void changePlayear(int plid, int hiid)
        {
            dlp.changePlayear(plid, hiid);
        }

    }
}
