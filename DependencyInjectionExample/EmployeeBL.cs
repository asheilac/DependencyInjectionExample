using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class EmployeeBL
    {
        public EmployeeDAL employeeDal;

        public List<Employee> GetAllEmployees()
        {
            employeeDal = new EmployeeDAL();
            return employeeDal.SelectAllEmployees();
        }
    }
}
