namespace BookCatalogueWPF.Domain.Entities
{

    /// <summary>
    /// Format:
    /// { "id": "1", "category": "4", "year": 2009, "publisher": "edinenie1", "title": "Breakfast for Dinner", "author": "Amanda Camp", "annotation":  "123456"},
    /// </summary>
    public class Book
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long Year { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Annotation { get; set; }

    }
}
