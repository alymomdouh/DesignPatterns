using _2_Strategy.Strategy;

namespace _2_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            while (true)
            {
                var emp = new Employee();

                Console.Write("\nEnter employee name: ");
                emp.Name = Console.ReadLine();

                Console.WriteLine("Select employee type:");
                foreach (var val in Enum.GetValues(typeof(EmployeeType)))
                {
                    Console.WriteLine($"{(int)val}. {val}");
                }

                int typeChoice = int.Parse(Console.ReadLine());
                emp.Type = (EmployeeType)typeChoice;

                switch (emp.Type)
                {
                    case EmployeeType.FullTime:
                        Console.Write("Enter base salary: ");
                        emp.BaseSalary = decimal.Parse(Console.ReadLine());

                        Console.Write("Enter bonus: ");
                        emp.Bonus = decimal.Parse(Console.ReadLine());
                        break;

                    case EmployeeType.Hourly:
                        Console.Write("Enter hours worked: ");
                        emp.HoursWorked = int.Parse(Console.ReadLine());

                        Console.Write("Enter hourly rate: ");
                        emp.HourlyRate = decimal.Parse(Console.ReadLine());
                        break;

                    case EmployeeType.TaskBased:
                        Console.Write("Enter completed tasks: ");
                        emp.CompletedTasks = int.Parse(Console.ReadLine());

                        Console.Write("Enter pay per task: ");
                        emp.PayPerTask = decimal.Parse(Console.ReadLine());
                        break;

                    case EmployeeType.Freelancer:
                        Console.Write("Enter gross amount: ");
                        emp.GrossAmount = decimal.Parse(Console.ReadLine());
                        break;

                    case EmployeeType.Intern:
                        Console.WriteLine("No data needed. Intern salary is fixed.");
                        break;
                }

                //var payroll = new Calculate();
                //var salary = payroll.CalculateSalary(emp);

                var payroll = new PayrollService();
                var salary = payroll.CalculateSalary(emp);

                Console.WriteLine("\n--- Salary Report ---");
                Console.WriteLine($"👤 Name: {emp.Name}");
                Console.WriteLine($"💼 Type: {emp.Type}");
                Console.WriteLine($"💰 Salary: {salary} EGP");
            }
        }
    }
}
