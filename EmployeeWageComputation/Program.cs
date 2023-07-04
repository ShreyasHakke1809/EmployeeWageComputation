namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput=random.Next(0,2);
            Console.WriteLine("Random value :{0}", employeeInput);
            if (employeeInput == FULL_TIME) 
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if(employeeInput == PART_TIME)
                {
                Console.WriteLine("FullTime Employee is Present");
                empHrs = 4;
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