using Application.Core;
using Application.Questions.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Questions
{
    public class List
    {
        public class Query : IRequest<Result<List<QuestionDto>>> { }
        
        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Query, Result<List<QuestionDto>>>
        {
            public async Task<Result<List<QuestionDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<QuestionDto>>.Success(await context.Questions.ProjectTo<QuestionDto>(mapper.ConfigurationProvider).ToListAsync(cancellationToken));
            }
        }
    }
}