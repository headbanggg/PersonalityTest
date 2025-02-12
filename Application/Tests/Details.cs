using Application.Core;
using Application.Tests.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Tests
{
    public class Details
    {
        public class Query : IRequest<Result<TestDto>>
        {
            public string Id { get; set; }
        }

        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Query, Result<TestDto>>
        {
            public async Task<Result<TestDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var test = await context.Tests
                .ProjectTo<TestDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync( x => request.Id == x.Id,  cancellationToken);
                return Result<TestDto>.Success(test);
            }
        }
    }

}