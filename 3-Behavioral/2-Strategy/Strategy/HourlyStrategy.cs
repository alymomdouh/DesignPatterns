namespace _2_Strategy.Strategy
{
    public class HourlyStrategy : ISalaryCalculationStrategy
    {
        public decimal Calculate(Employee emp)
        {
            return emp.HoursWorked * emp.HourlyRate;
        }
    }
}
