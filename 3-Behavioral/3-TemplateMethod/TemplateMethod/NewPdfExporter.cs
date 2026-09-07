namespace _3_TemplateMethod.TemplateMethod
{
    public class NewPdfExporter : ReportExporterTemplate
    {
        protected override string Format(Report report)
        {
            return "Formatting as pdf...";
        }

        protected override void Save(string formatted)
        {
            Console.WriteLine(formatted);
            Console.WriteLine("Saving pdf file...");
        }


        protected override string GetHeader(Report report)
        {
            return base.GetHeader(report) + " To pdf :";
        }
    }
}
