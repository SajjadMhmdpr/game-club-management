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
    public class bl_history
    {
        dl_history dlh = new dl_history();

        public DataTable showFactor(int id, int con)
        {
            return dlh.showFactor(id, con);
        }

        public int pardakhtKolBedehi(int hiID)
        {
            return dlh.pardakhtKolBedehi(hiID);
        }

        public bool pardakhtNesfeOneHistory(int hiID, int amount)
        {
            return dlh.pardakhtNesfeOneHistory(hiID, amount);
        }

        public int add(int emID, string date, string start)
        {
            return dlh.add(emID, date, start);
        }

        public History showInformationPardakht(int hiID)
        {
            return dlh.showInformationPardakht(hiID);
        }

        public History searchAndReturnHistory(int hiId)
        {
            return dlh.searchAndReturnHistory(hiId);
        }

        /*public History openHistory(int emID, string date, string start)
        {
            return dlh.openHistory(emID, date, start);
        }*/

        public DataTable readAndShowForDarhalEjra()
        {
            return dlh.readAndShowForDarhalEjra();
        }

        public DataTable searchAndShowForDarhalEjra(string s)
        {
            return dlh.searchAndShowForDarhalEjra(s);
        }

        public DataTable showGamesPlayed(int id)
        {
            return dlh.showGamesPlayed(id);
        }

        public void delete(int plID)
        {
            dlh.delete(plID);
        }

        public int calPriceFactorsInPardahktPage(int plid)
        {
            return dlh.calPriceFactorsInPardahktPage(plid);
        }

        public DataTable showAllHistory(string sdate, string edate, ref int daramad, ref int bedehi)
        {
            return dlh.showAllHistory(sdate, edate,ref daramad, ref bedehi);
        }

        public DataTable showAllHistorysWhitFilters(string sd, string ed, List<string> desks, ref int daramad, ref int bedehi)
        {
            return dlh.showAllHistorysWhitFilters(sd, ed, desks,ref daramad, ref bedehi);
        }

        public DataTable showAllBedehi()
        {
            return dlh.showAllBedehi();
        }



        public DataTable showAndSearchInDayliHistory(string s, bool pardakhtSHod, bool pardakhtNashod, bool darEjra)
        {
            return dlh.showAndSearchInDayliHistory(s, pardakhtSHod, pardakhtNashod, darEjra);
        }
    }
}
