using Application.TestResults;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TestResultsController : BaseAPIController
    {

        [HttpGet]
        public async Task<IActionResult> GetTestResults()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestResult(Guid id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestResult(TestResult testResult)
        {
            return HandleResult(await Mediator.Send(new Create.Command { TestResult = testResult }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditTestResult(Guid id, TestResult testResult)
        {
            testResult.Id = id;

            return HandleResult(await Mediator.Send(new Edit.Command { TestResult = testResult }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestResult(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}