using Task1_Interfaces;
using Task2_Extensions;

List<IEmployee> employees = new List<IEmployee>
{
    new Developer(1, "Aibek", 2500, "C#"),
    new Developer(2, "Dina", 3000, "Java"),
    new Manager(3, "Marat", 3500, "Development"),
    new Manager(4, "Aigul", 2800, "Marketing")
};

Console.WriteLine("Все сотрудники:");
employees.DisplayEmployeeDetails();

Console.WriteLine($"\nСредняя зарплата: {employees.CalculateMeanSalary()}");

IEmployee top = employees.FindTopEarner();
Console.WriteLine($"Больше всех получает: {top.Name}");


Console.WriteLine("\nИмена:");
foreach (string name in employees.ExtractEmployeeNames())
{
    Console.WriteLine(name);
}