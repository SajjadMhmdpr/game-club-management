using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_access;
using model;

namespace bussiness_logic
{
    public class bl_employee
    {
        dl_employee dle = new dl_employee();

        public Employee search(Employee e)
        {
            return dle.search(e);
        }

        public List<Employee> showEmployees()
        {
            return dle.showEmployees();
        }

        public Employee search(int id)
        {
            return dle.search(id);
        }

        public bool addEmployee(Employee e)
        {
            return dle.addEmployee(e);
        }

        public bool update(Employee e)
        {
            return dle.update(e);
        }

        public void delete(int id)
        {
            dle.delete(id);
        }

        public bool searchUsername(string u)
        {
            return dle.searchUsername(u);
        }
    }
}
