using _3_TemplateMethod.TemplateMethod;

namespace _3_TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;





            var report = new Report
            {
                Title = "Weekly Summary"
            };

            //var word = new WordExporter();
            //word.Export(report);


            //var pdf = new PdfExporter();
            //pdf.Export(report);


            //var excel = new ExcelExporter();
            //excel.Export(report);


            ReportExporterTemplate exporter;

            exporter = new NewPdfExporter();
            exporter.Export(report);

            exporter = new NewWordExporter();
            exporter.Export(report);


            exporter = new NewExcelExporter();
            exporter.Export(report);
        }
    }
}
