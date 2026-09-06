using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChainOfResponsibility
{
    public class OrderProcessor
    {
        public void Process(User user, Product product, int quantity)
        {
            Console.WriteLine("🚀 Start Order Process...\n");

            if (!user.IsAuthenticated)
            {
                Console.WriteLine("❌ User is not authenticated.");
                return;
            }

            if (!user.CanBuy)
            {
                Console.WriteLine("❌ User does not have permission to buy.");
                return;
            }

            if (product.Stock < quantity)
            {
                Console.WriteLine("❌ Product out of stock.");
                return;
            }

            decimal total = product.Price * quantity;
            if (user.Balance < total)
            {
                Console.WriteLine("❌ Insufficient balance.");
                return;
            }

      

            bool paymentSuccess = Withdraw(user, total);
            if (!paymentSuccess)
            {
                Console.WriteLine("❌ Payment failed.");
                return;
            }

           
            int orderId = CreateOrder(user.Id, product.Id, quantity);
            Console.WriteLine($"✅ Order #{orderId} created successfully.");

            Console.WriteLine($"📧 Email sent to {user.Email}");

            Console.WriteLine("\n🏁 Process Complete.");
        }

       

        private bool Withdraw(User user, decimal amount)
        {
            if (user.Balance >= amount)
            {
                user.Balance -= amount;
                return true;
            }
            return false;
        }

        private int CreateOrder(int userId, int productId, int quantity)
        {
            return new Random().Next(1000, 9999); 
        }
    }

}
