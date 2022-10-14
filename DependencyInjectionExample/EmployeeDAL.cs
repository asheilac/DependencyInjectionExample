using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class EmployeeDAL: IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();

            ListEmployees.Add(new Employee(){ID = 1, Name = "Pranaya", Department = "IT"});
            ListEmployees.Add(new Employee(){ID = 2, Name = "Kumar", Department = "HR"});
            ListEmployees.Add(new Employee(){ID = 3, Name = "Sheila", Department = "ELT"});
            return ListEmployees;
        }
    }
}
