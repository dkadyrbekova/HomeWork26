using Task1_Interfaces;
using Task3_Lambdas;

List<IEmployee> employees = new List<IEmployee>
{
    new Developer(1, "Aibek", 2500, "C#"),
    new Developer(2, "Dina", 3000, "Java"),
    new Manager(3, "Marat", 3500, "Development"),
    new Manager(4, "Aigul", 2800, "Marketing")
};

Console.WriteLine("Зарплата больше 2700:");
employees.ChooseEmployees(e => e.Salary > 2700)
         .ExecuteForEachEmployee(e => Console.WriteLine(e.GetInfo()));


Console.WriteLine("\nТолько менеджеры:");
employees.ChooseEmployees(e => e is Manager)
         .ExecuteForEachEmployee(e => Console.WriteLine(e.Name));