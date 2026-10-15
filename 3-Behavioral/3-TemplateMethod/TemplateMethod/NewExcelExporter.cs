namespace _3_TemplateMethod.TemplateMethod
{
    public class NewExcelExporter : ReportExporterTemplate
    {
        protected override string Format(Report report)
        {
            return "Formatting as Excel...";
        }

        protected override void Save(string formatted)
        {
            Console.WriteLine(formatted);
            Console.WriteLine("Saving Excel file...");
        }


        protected override string GetHeader(Report report)
        {
            return base.GetHeader(report) + " To Execl :";
        }
    }
}
