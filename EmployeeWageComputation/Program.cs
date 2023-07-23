using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.AddCompanyObjectsInArray("Deloitt", 20, 15, 100);
            employeeWage.AddCompanyObjectsInArray("Microsoft", 25, 20, 105);
            employeeWage.IterateOverArray();
        }
    }    
}