using _4_Facade.Facade;

namespace _4_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("📁 Enter video file name (e.g., lesson1.avi): ");
            var fileName = Console.ReadLine();

            Console.Write("📧 Enter teacher's email: ");
            var email = Console.ReadLine();

            new VideoProcessingFacade().Process(fileName, email);





            //var uploader = new VideoUploader();
            //var converter = new VideoConverter();
            //var normalizer = new AudioNormalizer();
            //var metadataExtractor = new MetadataExtractor();
            //var cdnUploader = new CdnUploader();
            //var notifier = new Notifier();

            //var path = uploader.Save(fileName);
            //Console.WriteLine($"✅ Video saved at: {path}");

            //var mp4Path = converter.ConvertToMp4(path);
            //Console.WriteLine($"🎞️ Video converted to MP4: {mp4Path}");

            //normalizer.Normalize(mp4Path);
            //Console.WriteLine($"🔊 Audio normalized.");

            //var metadata = metadataExtractor.Extract(mp4Path);
            //Console.WriteLine($"📏 Video metadata:");
            //Console.WriteLine($"   🕒 Duration   : {metadata.Duration}");
            //Console.WriteLine($"   📐 Resolution : {metadata.Resolution}");
            //Console.WriteLine($"   💾 Size       : {metadata.SizeInMB}MB");

            //var cdnUrl = cdnUploader.Upload(mp4Path);
            //notifier.Send(email, cdnUrl);

            //Console.WriteLine("✅ Video is ready to publish!");
        }
    }
}
