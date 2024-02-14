using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Employee
    {
        public int id { get; set; }
        public string emName { get; set; }
        public string emFamily { get; set; }
        public string emPhone { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool emState { get; set; }
        public bool manager { get; set; }
    }
}
