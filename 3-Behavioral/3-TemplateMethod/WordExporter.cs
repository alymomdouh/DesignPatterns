namespace _3_TemplateMethod
{
    public class WordExporter
    {
        public void Export(Report report)
        {
            Console.WriteLine($"📄 Exporting '{report.Title}' to Word:");
            Console.WriteLine("Fetching data...");
            Console.WriteLine("Formatting as Word...");
            Console.WriteLine("Saving Word...");
            Console.WriteLine("Logging...");
            Console.WriteLine("Auditing...\n");

        }
    }
}
