using Application.Core;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Answers
{
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Answer Answer { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Answer).SetValidator(new AnswerValidator());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var answer = await _context.Answers.FindAsync(request.Answer.Id);
                if (answer == null) return null;

                _mapper.Map(request.Answer, answer);
                var result = await _context.SaveChangesAsync() > 0;
                if (!result) return Result<Unit>.Failure("Failed to update answer");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}