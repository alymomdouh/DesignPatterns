namespace _2_Strategy.Strategy
{
    public class SalaryStrategyFactory
    {
        public static ISalaryCalculationStrategy GetStrategy(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.FullTime => new FulltimeStrategy(),
                EmployeeType.Hourly => new HourlyStrategy(),
                EmployeeType.TaskBased => new TaskBasedStrategy(),
                EmployeeType.Intern => new InternStrategy(),
                EmployeeType.Freelancer => new FreelancerStrategy(),
                _ => throw new NotSupportedException("Unknown employee type")
            };
        }
    }
}
