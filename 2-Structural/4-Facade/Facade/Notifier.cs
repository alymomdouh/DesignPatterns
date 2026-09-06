namespace _4_Facade.Facade
{
    public class Notifier
    {
        public void Send(string email, string videoUrl)
        {
            Console.WriteLine($"📧 Email sent to {email} with video link: {videoUrl}");
        }
    }
}