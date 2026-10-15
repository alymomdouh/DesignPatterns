namespace _2_Strategy.Strategy
{
    public class InternStrategy : ISalaryCalculationStrategy
    {
        public decimal Calculate(Employee emp)
        {
            return 1000;
        }
    }
}
