using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.Questions.DTOs
{
    public class QuestionDto
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public int Index { get; set; }
        public string TestName { get; set; }
        public string TestId { get; set; }
        public int AnswerOptionsCount { get; set; }
    }
}