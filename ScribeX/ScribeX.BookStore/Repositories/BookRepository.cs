using ScribeX.BookStore.Models;

namespace ScribeX.BookStore.Repositories
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book? GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        
        public Book? GetBookByAuthor(string author)
        {
            return DataSource().Where(x => x.Author.Contains(author)).FirstOrDefault();
        }

        public List<Book> DataSource()
        {
            return new List<Book>{
            new Book
            {
                Id = 1,
                Title = "Clean Code",
                Description = "A Handbook of Agile Software Craftsmanship.",
                Author = "Robert C. Martin",
                Price = 45.99,
                Language = "English",
                Pages = 464,
                ImageName = "Book1.jpg"
            },
            new Book
            {
                Id = 2,
                Title = "The Pragmatic Programmer",
                Description = "Your Journey to Mastery.",
                Author = "Andrew Hunt, David Thomas",
                Price = 39.50,
                Language = "English",
                Pages = 352,
                ImageName = "Book2.jpg"
            },
            new Book
            {
                Id = 3,
                Title = "Design Patterns",
                Description = "Elements of Reusable Object-Oriented Software.",
                Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                Price = 49.99,
                Language = "English",
                Pages = 395,
                ImageName = "Book3.jpg"
            },
            new Book
            {
                Id = 4,
                Title = "Refactoring",
                Description = "Improving the Design of Existing Code.",
                Author = "Martin Fowler",
                Price = 42.75,
                Language = "English",
                Pages = 448,
                ImageName = "Book4.jpg"
            },
            new Book
            {
                Id = 5,
                Title = "Introduction to Algorithms",
                Description = "Comprehensive algorithms reference.",
                Author = "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein",
                Price = 89.99,
                Language = "English",
                Pages = 1312,
                ImageName = "Book5.jpg"
            },
            new Book
            {
                Id = 6,
                Title = "Code Complete",
                Description = "A practical handbook of software construction.",
                Author = "Steve McConnell",
                Price = 55.00,
                Language = "English",
                Pages = 960,
                ImageName = "Book6.jpg"
            },
            new Book
            {
                Id = 7,
                Title = "Head First Design Patterns",
                Description = "A brain-friendly guide to design patterns.",
                Author = "Eric Freeman, Elisabeth Robson",
                Price = 44.20,
                Language = "English",
                Pages = 694,
                ImageName = "Book7.jpg"
            },
            new Book
            {
                Id = 8,
                Title = "Domain-Driven Design",
                Description = "Tackling Complexity in the Heart of Software.",
                Author = "Eric Evans",
                Price = 60.00,
                Language = "English",
                Pages = 560,
                ImageName = "Book8.jpg"
            },
            new Book
            {
                Id = 9,
                Title = "The Art of Computer Programming",
                Description = "Classic multi-volume work on algorithms and programming.",
                Author = "Donald E. Knuth",
                Price = 190.00,
                Language = "English",
                Pages = 3168,
                ImageName = "Book9.jpg"
            },
            new Book
            {
                Id = 10,
                Title = "Working Effectively with Legacy Code",
                Description = "Techniques for improving and modifying legacy systems safely.",
                Author = "Michael Feathers",
                Price = 38.95,
                Language = "English",
                Pages = 456,
                ImageName = "Book10.jpg"
            }};
        }
    }
}
