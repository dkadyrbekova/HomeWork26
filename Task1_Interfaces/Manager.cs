namespace Task1_Interfaces;

public class Manager : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public Manager(int id, string name, decimal salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string GetInfo()
    {
        return $"Manager #{Id} {Name}, salary: {Salary}, team size: {Department}";
    }
}