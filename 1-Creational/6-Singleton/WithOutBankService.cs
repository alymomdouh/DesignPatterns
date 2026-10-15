namespace _6_Singleton
{
    public class WithOutBankService
    {
        private decimal _balance = 10000;
        private readonly static object _lockBalance = new();

        public void Withdraw(decimal amount)
        {
            lock (_lockBalance)
            {
                #region message
                Console.WriteLine("\n➡️ [Thread 1]");
                Console.WriteLine($"[⏱ {DateTime.Now:HH:mm:ss.fff}] 🏧 Withdrawal Request: {amount} SAR");
                #endregion
                Thread.Sleep(500);

                if (_balance >= amount)
                {
                    _balance -= amount;
                    #region message
                    Console.WriteLine("✅ [Thread 1] 🏦 Withdrawal successful");
                    Console.WriteLine($"📊 Remaining Balance (in Thread 1): {_balance} SAR\n");
                    #endregion
                }
                else
                {
                    Console.WriteLine("❌ [Thread 1] 🚫 Insufficient funds");
                    Console.WriteLine($"📊 Current Balance: {_balance} SAR\n");
                }
            }

        }

        public void Deposit(decimal amount)
        {
            lock (_lockBalance)
            {
                #region message
                Console.WriteLine("\n➡️ [Thread 2]");
                Console.WriteLine($"[⏱ {DateTime.Now:HH:mm:ss.fff}] 💸 Deposit Request: {amount} SAR");
                #endregion

                Thread.Sleep(500);

                _balance += amount;

                #region message
                Console.WriteLine("✅ [Thread 2] 💰 Deposit successful");
                Console.WriteLine($"📊 New Balance (in Thread 2): {_balance} SAR\n");
                #endregion
            }

        }
    }
}