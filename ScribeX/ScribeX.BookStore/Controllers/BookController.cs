using Microsoft.AspNetCore.Mvc;
using ScribeX.BookStore.Models;
using ScribeX.BookStore.Services;

namespace ScribeX.BookStore.Controllers
{
    public class BookController : Controller
    {
        BookService bookService;
        public BookController()
        {
            bookService = new BookService();
        }
        public ViewResult Index()
        {
            List<Book> books = bookService.GetAllBooks();
            return View(books);
        }

        public ViewResult About()
        {
            return View();
        }
        
        public ViewResult Contact()
        {
            return View();
        }
    }
}
