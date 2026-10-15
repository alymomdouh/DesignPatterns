namespace _2_Strategy.Strategy
{
    public class FreelancerStrategy : ISalaryCalculationStrategy
    {
        public decimal Calculate(Employee emp)
        {
            var gross = emp.GrossAmount;
            var tax = gross * 0.1m;
            var commission = gross * 0.05m;
            return gross - tax - commission;
        }
    }
}
