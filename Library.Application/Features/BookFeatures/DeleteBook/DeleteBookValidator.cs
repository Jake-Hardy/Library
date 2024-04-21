using FluentValidation;

namespace Library.Application.Features.BookFeatures.DeleteBook;

public sealed class DeleteBookValidator : AbstractValidator<DeleteBookRequest>
{
    public DeleteBookValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
