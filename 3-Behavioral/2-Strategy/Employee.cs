namespace _2_Strategy
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public EmployeeType Type { get; set; }

        // FullTime
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }

        // Hourly
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        // TaskBased
        public int CompletedTasks { get; set; }
        public decimal PayPerTask { get; set; }

        // Freelancer
        public decimal GrossAmount { get; set; }


    }


    public enum EmployeeType
    {
        FullTime,
        Hourly,
        TaskBased,
        Intern,
        Freelancer
    }

}
