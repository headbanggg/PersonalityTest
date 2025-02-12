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
    public class List
    {
        public class Query : IRequest<Result<List<TestDto>>> { }

        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Query, Result<List<TestDto>>>
        {
            public async Task<Result<List<TestDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<TestDto>>.Success(await context.Tests.ProjectTo<TestDto>(mapper.ConfigurationProvider).ToListAsync(cancellationToken));
            }
        }
    }
}