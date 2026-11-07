using Task1_Interfaces;

namespace Task3_Lambdas;

public static class EmployeeLambdaExtensions
{
    // Фильтрация
    public static List<IEmployee> ChooseEmployees(this IEnumerable<IEmployee> employees, Func<IEmployee, bool> predicate)
    {
        List<IEmployee> result = new List<IEmployee>();

        foreach (IEmployee emp in employees)
        {
            if (predicate(emp))
            {
                result.Add(emp);
            }
        }
        return result;
    }

   

    // действие над каждым
    public static void ExecuteForEachEmployee(this IEnumerable<IEmployee> employees, Action<IEmployee> action)
    {
        foreach (IEmployee emp in employees)
        {
            action(emp);
        }
    }
}