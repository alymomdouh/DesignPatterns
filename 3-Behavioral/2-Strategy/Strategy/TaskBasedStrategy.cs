namespace _2_Strategy.Strategy
{
    public class TaskBasedStrategy : ISalaryCalculationStrategy
    {
        public decimal Calculate(Employee emp)
        {
            return emp.CompletedTasks * emp.PayPerTask;
        }
    }
}
