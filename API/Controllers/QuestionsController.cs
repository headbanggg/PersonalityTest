using Application.Questions;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class QuestionsController : BaseAPIController
    {

        [HttpGet] //api/questions
        public async Task<IActionResult> GetQuestions()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")] //api/guidasdsadsa
        public async Task<IActionResult> GetQuestion(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost] //api/guidasdsadsa
        public async Task<IActionResult> CreateQuestion(Question question)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Question = question }));
        }

        [HttpPut("{id}")] //api/questions/guidasdsadsa
        public async Task<IActionResult> EditQuestion(Guid id, Question question)
        {
            question.Id = id;
            
            return HandleResult(await Mediator.Send(new Edit.Command { Question = question }));
        }

        [HttpDelete("{id}")] //api/guidasdsadsa
        public async Task<IActionResult> DeleteQuestion(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}