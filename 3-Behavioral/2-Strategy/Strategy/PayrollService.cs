namespace _2_Strategy.Strategy
{
    public class PayrollService
    {
        public decimal CalculateSalary(Employee emp)
        {
            var strategy = SalaryStrategyFactory.GetStrategy(emp.Type);
            return strategy.Calculate(emp);
        }
    }
}
