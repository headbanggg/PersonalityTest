using Application.Answers;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AnswersController : BaseAPIController
    {

        [HttpGet]
        public async Task<IActionResult> GetAnswers()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAnswer(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnswer(Answer answer)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Answer = answer }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditAnswer(Guid id, Answer answer)
        {
            answer.Id = id;

            return HandleResult(await Mediator.Send(new Edit.Command { Answer = answer }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswer(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}