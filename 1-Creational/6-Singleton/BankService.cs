namespace _6_Singleton
{
    public class BankService
    { 
        private static BankService _instance;
        private static readonly object _lockinstance = new();
        private static readonly object _lockBalance = new();
        private decimal _balance = 10000;

        private BankService() { Thread.Sleep(3000); }

        public static BankService Instance
        {
            get
            {
                lock (_lockinstance)
                {
                    if (_instance == null)
                    {
                        _instance = new BankService();
                    }
                    return _instance;
                }
            }
        }

        public void Withdraw(decimal amount)
        {
            lock (_lockBalance)
            {
                #region message
                Console.WriteLine("\n➡️ [Thread 1]");
                Console.WriteLine($"[⏱ {DateTime.Now:HH:mm:ss.fff}] 🏧 Withdrawal Request: {amount} SAR");
                #endregion

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
                Console.WriteLine("\n➡️ [Thread 2]");
                Console.WriteLine($"[⏱ {DateTime.Now:HH:mm:ss.fff}] 💸 Deposit Request: {amount} SAR");

                _balance += amount;


                Console.WriteLine("✅ [Thread 2] 💰 Deposit successful");
                Console.WriteLine($"📊 New Balance (in Thread 2): {_balance} SAR\n");
            }
        }



    }
}