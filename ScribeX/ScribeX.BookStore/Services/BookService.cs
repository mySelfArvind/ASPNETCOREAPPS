using ScribeX.BookStore.Models;
using ScribeX.BookStore.Repositories;

namespace ScribeX.BookStore.Services
{
    public class BookService
    {
        BookRepository bookRepository;
        public BookService()
        {
            bookRepository = new BookRepository();
        }
        public List<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }

        public Book? GetBookById(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public Book? GetBookByAuthor(string author)
        {
            return bookRepository.GetBookByAuthor(author);
        }
    }
}
