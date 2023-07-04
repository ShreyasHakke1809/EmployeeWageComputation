namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput=random.Next(0,2);
            Console.WriteLine("Random value :{0}", employeeInput);
            if (employeeInput==IS_PRESENT) 
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}