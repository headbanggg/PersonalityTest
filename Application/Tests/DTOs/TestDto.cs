using Application.Profiles;

namespace Application.Tests.DTOs
{
    public class TestDto
    {
        public string Id { get; set; }
        public string TestName { get; set; }
        public string TestType { get; set; }
        public int QuestionCount { get; set; }
        public int AnswerOptionsCount { get; set; }
        public int EstimatedTimeInMinutes { get; set; }
        public List<QuestionProfile> QuestionList { get; set; } = [];
    }
}