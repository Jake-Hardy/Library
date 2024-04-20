using Library.Domain.Common;

namespace Library.Domain.Entities
{
    public sealed class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }        
    }
}
