using DependencyInjectionExample;

//Constructor Dependency Injection
//EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
//List<Employee> ListEmployee = employeeBL.GetAllEmployees();
//foreach (var emp in ListEmployee)
//{
//    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
//}

//Property Dependency Injection 
//EmployeeBL employeeBL = new EmployeeBL();
//employeeBL.employeeDataObject = new CheeseEmployees();
//List<Employee> ListEmployee = employeeBL.GetAllEmployees();
//foreach (var emp in ListEmployee)
//{
//    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
//}

////Method Dependency Injection
EmployeeBL employeeBL = new EmployeeBL();
List<Employee> ListEmployee = employeeBL.GetAllEmployees(new CatEmployees());
foreach (var emp in ListEmployee)
{
    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
}