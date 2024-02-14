using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using data_access;

namespace bussiness_logic
{
    public class bl_login
    {
        dl_login dll = new dl_login();
        public Employee search(Employee e)
        {
            return dll.search(e);
        }
    }
}
