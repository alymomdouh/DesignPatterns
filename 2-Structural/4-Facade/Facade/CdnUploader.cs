namespace _4_Facade.Facade
{
    public class CdnUploader
    {
        public string Upload(string path)
        {
            var cdnUrl = $"https://cdn.udemy.com/{Path.GetFileName(path)}";
            Console.WriteLine($"☁️ Uploaded video to CDN: {cdnUrl}");
            return cdnUrl;
        }
    }
}