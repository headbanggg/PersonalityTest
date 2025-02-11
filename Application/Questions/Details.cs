using Application.Core;
using Application.Questions.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Questions
{
    public class Details
    {
        public class Query : IRequest<Result<QuestionDto>>
        {
            public string Id { get; set; }
        }

        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Query, Result<QuestionDto>>
        {
            public async Task<Result<QuestionDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var question = await context.Questions
                .ProjectTo<QuestionDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => request.Id == x.Id, cancellationToken);
                return Result<QuestionDto>.Success(question);
            }
        }
    }

}