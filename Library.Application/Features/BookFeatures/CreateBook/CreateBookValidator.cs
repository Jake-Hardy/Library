using FluentValidation;

namespace Library.Application.Features.BookFeatures.CreateBook;

public sealed class CreateBookValidator : AbstractValidator<CreateBookRequest>
{
    public CreateBookValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Author).NotEmpty();
        RuleFor(x => x.Genre).NotEmpty();
    }
}
