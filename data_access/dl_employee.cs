using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace data_access
{
    public class dl_employee
    {
        DB db = new DB();

        public Employee search(Employee e)
        {
            var q = from i in db.Employees where i.emState && i.username == e.username &&
                    i.password == e.password select i;
            if (!q.Any())
            {
                e.id = -1;
                return e;
            }
            return q.Single();
        }

        public List<Employee> showEmployees()
        {
            var q = from i in db.Employees where i.emState select i;
            return q.ToList();
        }

        public Employee search(int id)
        {
            var q = from i in db.Employees where i.emState && i.id == id select i;
            return q.Single();
        }

        public bool searchUsername(string u)
        {
            var q = from i in db.Employees where i.username == u select i;
            if (q.Count() > 0)
                return true;

            return false;
        }

        public bool addEmployee(Employee e)
        {
            var q1 = from i in db.Employees  select i;

            if (searchUsername(e.username))
                return false;

            if (q1.Count() == 0)
                e.manager = true;
            else
                e.manager = false;

            e.emState = true;

            db.Employees.Add(e);

            db.SaveChanges();

            return true;
        }

        public bool update(Employee e)
        {
            var q1 = from i in db.Employees where   i.id != e.id && i.username==e.username select i;

            if (q1.Any())
                return false;

            var q = from i in db.Employees where i.emState && i.id == e.id select i;

            q.Single().emName = e.emName;
            q.Single().emFamily = e.emFamily;
            q.Single().emPhone = e.emPhone;
            q.Single().username = e.username;
            q.Single().password = e.password;

            db.SaveChanges();

            return true;
        }

        public void delete(int id)
        {
            var q = from i in db.Employees where i.emState && i.id == id && i.manager==false select i;

            q.Single().emState = false;

            db.SaveChanges();
        }
    }
}
