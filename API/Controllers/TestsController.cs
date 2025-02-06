using Application.Tests;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TestsController : BaseAPIController
    {

        [HttpGet] //api/tests
        public async Task<IActionResult> GetTests()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")] //api/guidasdsadsa
        public async Task<IActionResult> GetTest(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost] //api/guidasdsadsa
        public async Task<IActionResult> CreateTest(Test test)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Test = test }));
        }

        [HttpPut("{id}")] //api/questions/guidasdsadsa
        public async Task<IActionResult> EditTest(Guid id, Test test)
        {
            test.Id = id;

            return HandleResult(await Mediator.Send(new Edit.Command { Test = test }));
        }

        [HttpDelete("{id}")] //api/guidasdsadsa
        public async Task<IActionResult> DeleteTest(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}