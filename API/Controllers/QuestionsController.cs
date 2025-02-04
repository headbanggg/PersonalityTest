using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class QuestionsController : BaseAPIController
    {
        private readonly DataContext _context;
        public QuestionsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //api/questions
        public async Task<ActionResult<List<Question>>> GetQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        [HttpGet("{id}")] //api/guidasdsadsa
        public async Task<ActionResult<Question>> GetQuestion(Guid id)
        {
            return await _context.Questions.FindAsync(id);
        }
    }
}