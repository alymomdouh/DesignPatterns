namespace _6_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("===========================================");
            Console.WriteLine("🏦  BANK TRANSACTION SESSION STARTED");
            Console.WriteLine("===========================================\n");

            Console.WriteLine("🔄 Parallel operations initiated on account with starting balance: 10,000 SAR");


            var t1 = new Thread(() =>
            {
                var bank = new WithOutBankService();
                bank.Withdraw(7000);
            });

            var t2 = new Thread(() =>
            {
                var bank = new WithOutBankService();
                bank.Deposit(5000);
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();




            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("===========================================");
            //Console.WriteLine("🏦  Singleton Transaction Test");
            //Console.WriteLine("===========================================\n");

            //// First access (will create the instance)
            //Console.WriteLine("➡️ First access (Withdraw 3000) [Expected: slow]");


            //var sw1 = Stopwatch.StartNew();
            //BankService.Instance.Withdraw(3000);
            //BankService.Instance.Deposit(5000);
            //sw1.Stop();
            //Console.WriteLine($"⏱️ First access time: {sw1.ElapsedMilliseconds} ms\n");

            //// Second access (instance already exists)
            //Console.WriteLine("➡️ Second access (Deposit 5000) [Expected: fast]");
            //var sw2 = Stopwatch.StartNew();
            //BankService.Instance.Withdraw(2000);
            //BankService.Instance.Deposit(5000);
            //sw2.Stop();
            //Console.WriteLine($"⏱️ Second access time: {sw2.ElapsedMilliseconds} ms\n");

            //Console.WriteLine("✅ Done: First time = Singleton creation + Withdraw, Second time = Just Deposit.");
        }
    }
}
