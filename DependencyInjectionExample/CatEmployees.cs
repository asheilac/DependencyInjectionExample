using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class CatEmployees: IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListCatEmployees = new List<Employee>();
            ListCatEmployees.Add(new Employee() { ID = 1, Name = "Freya", Department = "Security" });
            ListCatEmployees.Add(new Employee() { ID = 2, Name = "Loki", Department = "Mental Health" });

            return ListCatEmployees;
        }
    }
}
