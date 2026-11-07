using Task1_Interfaces;

namespace Task2_Extensions;

public static class EmployeeExtensions
{
    // вычисление средней зарплаты

    public static decimal CalculateMeanSalary(this IEnumerable<IEmployee> employees)
    {
        decimal sum = 0;
        int count = 0;

        foreach (IEmployee emp in employees)
        {
            sum += emp.Salary;
            count++;
        }

        if (count == 0)
        {
            return 0;
        }

        return sum / count;
    }

    //emp с максимальной зарплатой
    public static IEmployee FindTopEarner(this IEnumerable<IEmployee> employees)
    {
        IEmployee top = null;

        foreach (IEmployee emp in employees)
        {
            if (top == null || emp.Salary > top.Salary)
            {
                top = emp;
            }
        }
        return top;
    }


    // список имён
    public static List<string> ExtractEmployeeNames(this IEnumerable<IEmployee> employees)
    {
        List<string> names = new List<string>();

        foreach (IEmployee emp in employees)
        {
            names.Add(emp.Name);
        }

        return names;
    }

    //Вывод информации
    public static void DisplayEmployeeDetails(this IEnumerable<IEmployee> employees)
    {
        foreach (IEmployee emp in employees)
        {
            Console.WriteLine(emp.GetInfo());
        }
    }
}