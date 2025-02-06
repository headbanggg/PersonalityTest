using Domain;
using FluentValidation;

namespace Application.Answers
{
    public class AnswerValidator : AbstractValidator<Answer>
    {
         public AnswerValidator() 
            { 
                RuleFor(x => x.SelectionIndex).NotEmpty();
            }
    }
}