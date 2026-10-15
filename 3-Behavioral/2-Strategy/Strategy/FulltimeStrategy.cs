namespace _2_Strategy.Strategy
{
    public class FulltimeStrategy : ISalaryCalculationStrategy
    {
        public decimal Calculate(Employee emp)
        {
            return emp.BaseSalary + emp.Bonus;
        }
    }
}
