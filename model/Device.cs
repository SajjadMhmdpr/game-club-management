using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Game
    {
        public int id { get; set; }
        public string acName { get; set; }
        public double acPrice { get; set; }
        public double acControllerPrice { get; set; }
        public bool acState { get; set; }
        public bool acState2 { get; set; }
        public List<Desk> desks { get; set; } = new List<Desk>();

    }
    public class Desk
    {
        public int id { get; set; }
        public string deskCode { get; set; }
        public bool deState { get; set; }
        public bool deState2 { get; set; }
        public Game deGame { get; set; }
    }
}
