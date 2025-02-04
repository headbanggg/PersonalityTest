namespace Domain
{
    public class TestResult
    {
        public Guid Id { get; set; }
        public Test relatedTest { get; set; }
        public List<Answer> AnswerList { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }
    }
}