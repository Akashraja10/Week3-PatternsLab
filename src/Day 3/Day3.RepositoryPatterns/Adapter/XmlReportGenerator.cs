using System;

namespace Day3.RepositoryPatterns.Adapter
{
	public class XmlReportGenerator
    {
		public void GenerateXml(string xml)
		{
            Console.WriteLine("Third Party XML Generator");
            Console.WriteLine(xml);
        }
    }
}
