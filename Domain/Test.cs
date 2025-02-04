namespace Domain
{
    public class Test
    {
        public Guid Id { get; set; }
        public string TestName { get; set; }
        public string TestType { get; set; }
        public int QuestionCount { get; set; }
        public int AnswerOptionsCount { get; set; }
        public int EstimatedTimeInMinutes { get; set; }
        public List<Question> QuestionList { get; set; }
    }
}