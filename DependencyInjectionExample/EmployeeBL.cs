using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDal;

        public EmployeeBL(IEmployeeDAL employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDal.SelectAllEmployees();
        }
    }
}
