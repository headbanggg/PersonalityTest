namespace Domain
{
    public class TestResult
    {
        public Guid Id { get; set; }
        public Test RelatedTest { get; set; }
        public List<Answer> RelatedAnswerList { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }
        public AppUser User { get; set; }
    }
}