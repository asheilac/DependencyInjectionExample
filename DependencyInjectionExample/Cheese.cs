using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class Cheese: IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListCheeseEmployees = new List<Employee>();
            ListCheeseEmployees.Add(new Employee(){ID = 1, Name = "Mozarella", Department = "Dinner"});
            ListCheeseEmployees.Add(new Employee() { ID = 2, Name = "Feta", Department = "Lunch" });

            return ListCheeseEmployees;
        }
    }
}
