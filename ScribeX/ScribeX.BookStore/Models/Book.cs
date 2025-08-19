namespace ScribeX.BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Language { get; set; } = string.Empty;
        public int Pages { get; set; }
        public string ImageName { get; set; } = "";
    }
}
