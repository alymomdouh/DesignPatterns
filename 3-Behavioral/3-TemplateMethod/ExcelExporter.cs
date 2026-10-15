namespace _3_TemplateMethod
{
    public class ExcelExporter
    {
        public void Export(Report report)
        {
            Console.WriteLine($"📊 Exporting '{report.Title}' to Excel:");
            Console.WriteLine("Fetching data...");
            Console.WriteLine("Formatting as Excel...");
            Console.WriteLine("Saving Excel...");
            Console.WriteLine("Logging...");
            Console.WriteLine("Auditing...\n");
        }
    }
}
