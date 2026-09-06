namespace _4_Facade.Facade
{
    public class VideoUploader
    {
        public string Save(string fileName)
        {
            string path = $"uploads/{fileName}";
            Directory.CreateDirectory("uploads");
            File.WriteAllText(path, $"Mock data for {fileName}");
            return path;
        }
    }
}