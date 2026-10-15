namespace _4_Facade.Facade
{
    public class VideoConverter
    {
        public string ConvertToMp4(string inputPath)
        {
            string outputPath = inputPath.Replace(".avi", ".mp4");
            File.WriteAllText(outputPath, $"Converted to MP4 from {inputPath}");
            return outputPath;
        }
    }
}