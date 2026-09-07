namespace _3_TemplateMethod.TemplateMethod
{
    public abstract class ReportExporterTemplate
    {

        public void Export(Report report)
        {
            Console.WriteLine(GetHeader(report));
            FetchData(report);
            var formatted = Format(report);
            Save(formatted);
            Log(report);
            Audit(report);
        }

        protected virtual void FetchData(Report report)
            => Console.WriteLine("Fetching Data....");

        protected virtual void Audit(Report report)
            => Console.WriteLine("Auditing...");

        protected virtual void Log(Report report)
            => Console.WriteLine("Logging");


        protected virtual string GetHeader(Report report)
        {
            return $"📊 Exporting '{report.Title}'";
        }


        protected abstract string Format(Report report);

        protected abstract void Save(string formatted);




    }
}