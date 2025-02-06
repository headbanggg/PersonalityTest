namespace Domain
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Question RelatedQuestion { get; set; }
        public int SelectionIndex { get; set; }
        public TestResult RelatedTestResult { get; set; }
    }
}