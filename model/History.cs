using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class History
    {
        public void setController(int c = 0)
        {
            hiPrice = desk.deGame.acPrice + c * desk.deGame.acControllerPrice;
            controlNum = c;
        }
        
        public int id { get; set; }
        public string date { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int activityTime { get; set; }
        public Desk desk { get; set; }
        public Employee employee { get; set; }
        public Player player { get; set; }
        public double hiHazineKol { get; set; }
        public double hiPrice { get; set; }
        public int controlNum { get; set; }
        public int Paid { get; set; }
        public bool conPardakht { get; set; }
        //public bool conChangeGame { get; set; }
    }


}
