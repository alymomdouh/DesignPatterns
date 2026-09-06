namespace _2_Strategy
{
    public class Calculate
    {
        public decimal CalculateSalary(Employee emp)
        {
            if (emp.Type == EmployeeType.FullTime)
            {
                return emp.BaseSalary + emp.Bonus;
            }
            else if (emp.Type == EmployeeType.Hourly)
            {
                return emp.HoursWorked * emp.HourlyRate;
            }
            else if (emp.Type == EmployeeType.TaskBased)
            {
                return emp.CompletedTasks * emp.PayPerTask;
            }
            else if (emp.Type == EmployeeType.Intern)
            {
                return 1000;
            }
            else if (emp.Type == EmployeeType.Freelancer)
            {
                var gross = emp.GrossAmount;
                var tax = gross * 0.1m;
                var commission = gross * 0.05m;
                return gross - tax - commission;
            }
            else
            {
                throw new Exception("Unknown employee type");
            }
        }
    }
}
