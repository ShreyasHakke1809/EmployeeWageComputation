namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput=random.Next(0,2);
            Console.WriteLine("Random value :{0}", employeeInput);
            if (employeeInput==IS_PRESENT) 
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Daily employee wage is :{0}", empWage);
            Console.ReadLine();
        }
    }
}