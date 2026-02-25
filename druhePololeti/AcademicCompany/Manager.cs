namespace AcademicCompany.Manager;

public class Manager : AcademicCompany.Employee.Employee
{
    public Manager(string fullName, int salary) : base(fullName, salary)
    {
    }

    public void PrintSalary()
    {
        Console.WriteLine($"Plat manažera je {CalculateFinalSalary()}");
    }
}
