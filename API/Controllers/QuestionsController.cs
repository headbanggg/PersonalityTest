using Application.Questions;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class QuestionsController : BaseAPIController
    {

        [HttpGet] //api/questions
        public async Task<ActionResult<List<Question>>> GetQuestions()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/guidasdsadsa
        public async Task<ActionResult<Question>> GetQuestion(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost] //api/guidasdsadsa
        public async Task<IActionResult> CreateQuestion(Question question)
        {
            await Mediator.Send(new Create.Command { Question = question });
            return Ok();
        }

        [HttpPut("{id}")] //api/questions/guidasdsadsa
        public async Task<IActionResult> EditQuestion(Guid id, Question question)
        {
            question.Id = id;
            await Mediator.Send(new Edit.Command { Question = question });
            return Ok();
        }

        [HttpDelete("{id}")] //api/guidasdsadsa
        public async Task<IActionResult> DeleteQuestion(Guid id)
        {
            await Mediator.Send(new Delete.Command { Id = id });
            return Ok();
        }
    }
}