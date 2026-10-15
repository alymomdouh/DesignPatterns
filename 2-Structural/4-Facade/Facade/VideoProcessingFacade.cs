namespace _4_Facade.Facade
{
    public class VideoProcessingFacade
    {

        private readonly VideoUploader _uploader = new();
        private readonly VideoConverter _converter = new();
        private readonly AudioNormalizer _normalizer = new();
        private readonly MetadataExtractor _meta = new();
        private readonly CdnUploader _cdnuploader = new();
        private readonly Notifier _notifier = new();


        public void Process(string fileName, string teacherEmail)
        {

            var path = _uploader.Save(fileName);
            Console.WriteLine($"✅ Video saved at: {path}");

            var mp4Path = _converter.ConvertToMp4(path);
            Console.WriteLine($"🎞️ Video converted to MP4: {mp4Path}");

            _normalizer.Normalize(mp4Path);
            Console.WriteLine($"🔊 Audio normalized.");

            var metadata = _meta.Extract(mp4Path);
            Console.WriteLine($"📏 Video metadata:");
            Console.WriteLine($"   🕒 Duration   : {metadata.Duration}");
            Console.WriteLine($"   📐 Resolution : {metadata.Resolution}");
            Console.WriteLine($"   💾 Size       : {metadata.SizeInMB}MB");

            var cdnUrl = _cdnuploader.Upload(mp4Path);
            _notifier.Send(teacherEmail, cdnUrl);

            Console.WriteLine("✅ Video is ready to publish!");
        }

    }
}