using Microsoft.AspNetCore.Mvc;

namespace ScribeX.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
