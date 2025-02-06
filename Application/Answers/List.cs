using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Answers
{
    public class List
    {
        public class Query : IRequest<Result<List<Answer>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Answer>>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Result<List<Answer>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<Answer>>.Success(await _context.Answers.ToListAsync(cancellationToken));
            }
        }
    }
}