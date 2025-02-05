using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Questions
{
    public class List
    {
        public class Query : IRequest<Result<List<Question>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Question>>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Result<List<Question>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<Question>>.Success(await _context.Questions.ToListAsync(cancellationToken));
            }
        }
    }
}