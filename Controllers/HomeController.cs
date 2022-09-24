using Microsoft.AspNetCore.Mvc;
using Module6HW5;
using Module6HW5.Models;
using System.Diagnostics;

namespace Module6HW5.Controllers
{
    public class HomeController : Controller
    {
        
       BookContext Books;
        public HomeController()
        {
            Books = BookContext.getInstance();
            
        }
        [HttpGet]
        public IActionResult Index()
        {            
            return View(Books.GetBooks());
        }
        [HttpGet]
        public IActionResult CreateBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBook(int Id,string Name,string Author,int Price,int YearofPublishing)
        {
            Books.AddBooks(Id,Name,Author,Price,YearofPublishing);
            Index();
            return View("Index");
        }
        public IActionResult DeleteBook(int Id)
        {
            Books.RemoveBook(Id);
            Index();
            return View("Index");
        }
        [HttpGet]
        public IActionResult EditBook(int Id)
        {            
            return View(Books.GetBook(Id));
        }
        [HttpPost]
        public IActionResult EditBook(int Id, string Name, string Author, int Price, int YearofPublishing)
        {
            Books.Updatebook(Id,Name,Author,Price,YearofPublishing);
            Index();
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}