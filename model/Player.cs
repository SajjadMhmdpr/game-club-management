using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Player
    {
        public int id { get; set; }
        public int plCode { get; set; }
        public string plName { get; set; }
        public string plFamily { get; set; }
        public string plPhone { get; set; }
        public List<History> historys { get; set; } = new List<History>();
        public double plHazineBedehi { get; set; }
        public double plChangeGamePrice { get; set; }
        public bool plState { get; set; }

    }

    public class Code
    {
        public int id { get; set; }
        public int code { get; set; }
    }
}
