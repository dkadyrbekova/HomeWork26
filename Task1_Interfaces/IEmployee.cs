namespace Task1_Interfaces;

public interface IEmployee
    {
    int Id { get; set; }
    string Name { get; set; }
    decimal Salary { get; set; }
    string GetInfo();
}