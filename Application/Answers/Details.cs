using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Answers
{
    public class Details
    {
        public class Query : IRequest<Result<Answer>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Answer>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Answer>> Handle(Query request, CancellationToken cancellationToken)
            {
                var answer = await _context.Answers.FindAsync(request.Id);
                return Result<Answer>.Success(answer);
            }
        }
    }
}