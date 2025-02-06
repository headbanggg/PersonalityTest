using Domain;
using FluentValidation;

namespace Application.Tests
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()
        {
            RuleFor(x => x.TestName).NotEmpty();
            RuleFor(x => x.TestType).NotEmpty();
            RuleFor(x => x.QuestionCount).NotEmpty();
            RuleFor(x => x.AnswerOptionsCount).NotEmpty();
            RuleFor(x => x.EstimatedTimeInMinutes).NotEmpty();
            RuleFor(x => x.QuestionList).NotEmpty();
        }
    }
}