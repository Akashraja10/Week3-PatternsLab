using System;

namespace Day3.RepositoryPatterns.Adapter
{
	public class XmlReportAdapter
    {
		private readonly XmlReportGenerator _xmlGenerator;

        public XmlReportAdapter()
        {
            _xmlGenerator = new XmlReportGenerator();
        }

        public void GenerateReport(JsonReport report)
        {
            string xml =
                    $@"<Report>
                        <Customer>{report.CustomerName}</Customer>
                        <Amount>{report.Amount}</Amount>
                    </Report>";

            _xmlGenerator.GenerateXml(xml);
        }
    }
}
