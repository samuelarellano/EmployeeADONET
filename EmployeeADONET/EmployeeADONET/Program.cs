using EmployeeADONET.BusinessLogic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        EmployeeBL employeeBL = new EmployeeBL();

        var listEmployee = employeeBL.GetAll();

        foreach (var e in listEmployee)
        {
            Console.WriteLine($"{e.Name} - {e.Occupation}");
        }
    }
}