namespace Library.Application.Features.BookFeatures.GetAllBook;

public sealed class GetAllBookResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
}
