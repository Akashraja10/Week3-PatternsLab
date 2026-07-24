namespace Day3.RepositoryPatterns.Adapter
{
    public class JsonReport
    {
        public string? CustomerName { get; set; }

        public decimal Amount { get; set; }

        public string ToJson()
        {
            return $"{{ \"Customer\":\"{CustomerName}\", \"Amount\":{Amount} }}";
        }
    }
}