using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class EmployeeBL
    {
        //Constructor DI *Starts Here*
        //public IEmployeeDAL employeeDAL;
        //public EmployeeBL(IEmployeeDAL employeeDal)
        //{
        //    this._employeeDal = employeeDal;
        //}
        //public List<Employee> GetAllEmployees()
        //{
        //    return _employeeDal.SelectAllEmployees();
        //}


        //Property DI *Starts Here*
        private IEmployeeDAL _employeeDal;
        public IEmployeeDAL employeeDataObject
        {
            set => this._employeeDal = value;
            get => (employeeDataObject == null) ? throw new Exception("Employee not initialized") : _employeeDal;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDal.SelectAllEmployees();
        }
    }
}
