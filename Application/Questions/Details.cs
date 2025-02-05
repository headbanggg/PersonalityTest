using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Questions
{
    public class Details
    {
        public class Query : IRequest<Result<Question>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Question>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Question>> Handle(Query request, CancellationToken cancellationToken)
            {
                var question = await _context.Questions.FindAsync(request.Id);
                return Result<Question>.Success(question);
            }
        }
    }

}