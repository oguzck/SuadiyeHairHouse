using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SuadiyeHairHouse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult BeforeAndAfter()
        {
            return View();
        }
        public IActionResult FrequentlyAskedQuestions()
        {
            return View();
        }


    }
}