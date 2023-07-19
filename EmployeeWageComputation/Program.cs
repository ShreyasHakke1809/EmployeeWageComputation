using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage.ComputeWage("Deloitt", 20, 15, 100);
            EmployeeWage.ComputeWage("Infosys", 25, 20, 105);
        }
    }    
}