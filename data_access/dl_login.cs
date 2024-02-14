using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace data_access
{
    public class dl_login
    {
        DB db = new DB();

        public Employee search(Employee e)
        {
            var q = from i in db.Employees where i.emState 
                    && i.username==e.username && i.password==e.password select i;
            if(!q.Any())
            {
                e.id = -1;
                return e;
            }
            return q.Single();
        }
    }
}
