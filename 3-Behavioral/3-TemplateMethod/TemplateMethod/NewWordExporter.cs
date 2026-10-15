namespace _3_TemplateMethod.TemplateMethod
{
    public class NewWordExporter : ReportExporterTemplate
    {
        protected override string Format(Report report)
        {
            return "Formatting as Word...";
        }

        protected override void Save(string formatted)
        {
            Console.WriteLine(formatted);
            Console.WriteLine("Saving Word file...");
        }


        protected override string GetHeader(Report report)
        {
            return base.GetHeader(report) + " To Word :";
        }
    }
}
