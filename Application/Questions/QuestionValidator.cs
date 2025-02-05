using Domain;
using FluentValidation;

namespace Application.Questions
{
    public class QuestionValidator : AbstractValidator<Question>
    {
         public QuestionValidator() 
            { 
                RuleFor(x => x.Content).NotEmpty();
                RuleFor(x => x.Index).NotEmpty();
            }
    }
}