using DependencyInjectionExample;

EmployeeBL employeeBL = new EmployeeBL(new Cheese());
List<Employee> ListEmployee = employeeBL.GetAllEmployees();
foreach (var emp in ListEmployee)
{
    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
}