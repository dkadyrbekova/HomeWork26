namespace Task1_Interfaces;

public class Developer : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Language { get; set; }

    public Developer(int id, string name, decimal salary, string language)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Language = language;
    }

    public string GetInfo()
    {
        return $"Developer #{Id} {Name}, salary: {Salary},language: {Language}";
    }
}