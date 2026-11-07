using Task1_Interfaces;

List<IEmployee> employees = new List<IEmployee>
{
    new Developer(1, "Aibek", 2500, "C#"),
    new Developer(2, "Dina", 3000, "Java"),
    new Manager(3, "Marat", 3500, "Development"),
    new Manager(4, "Aigul", 2800, "Marketing")
};

foreach (IEmployee emp in employees)
{
    Console.WriteLine(emp.GetInfo());
}