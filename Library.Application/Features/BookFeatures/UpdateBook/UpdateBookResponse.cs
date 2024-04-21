namespace Library.Application.Features.BookFeatures.UpdateBook;

public sealed record UpdateBookResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
}
