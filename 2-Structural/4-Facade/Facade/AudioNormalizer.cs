namespace _4_Facade.Facade
{
    public class AudioNormalizer
    {
        public void Normalize(string path)
        {
            var content = File.ReadAllText(path);
            content += "\n[Audio Normalized]";
            File.WriteAllText(path, content);
        }
    }
}