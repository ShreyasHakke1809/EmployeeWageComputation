using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;

            Console.WriteLine("Welcome To Employee Wage Computation");
            Random random = new Random();
            for (day = 1; day <= NUMBER_OF_WORKING_DAYS; day++)
            {
                 int employeeInput = random.Next(0, 3);
                 switch (employeeInput)
                {
                    case PART_TIME:
                       // Console.WriteLine("FullTime Employee Is Present");
                        empHrs = 8;
                        break;
                    case FULL_TIME:
                        //Console.WriteLine("PartTime Employee Is Present");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee Is Absent");
                        break;
                }
            empWage = empHrs * EMP_RATE_PER_HR;
            totalWage = totalWage + empWage;
            Console.WriteLine("Day{0} employee wage is:{1}",day, empWage);

            }
            Console.WriteLine("Total Wage for {0} days is:{1}", (day - 1), totalWage);
        }
    }
}
