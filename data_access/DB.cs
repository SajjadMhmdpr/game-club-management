using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using model;

namespace data_access
{
    public class DB : DbContext
    {
        public DB() : base("GameNet") { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Code> codes { get; set; }
    }
}
