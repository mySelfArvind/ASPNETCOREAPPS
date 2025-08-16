using Microsoft.AspNetCore.Mvc;

namespace ScribeX.BookStore.Controllers
{
    public class BookController : Controller
    {
        public ViewResult Index()
        {
            return View();
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
