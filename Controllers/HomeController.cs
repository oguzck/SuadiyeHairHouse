using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using SuadiyeHairHouse.Models;

namespace SuadiyeHairHouse.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
        }
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
        public IActionResult BeforeAndAfter()
        {
            return View();
        }
        public IActionResult FrequentlyAskedQuestions()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(SendMailDto sendMailDto)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                string To = "info@suadiyehairhouse.com.tr";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@suadiyehairhouse.com.tr", "İletişim Formu");
                mail.To.Add(To);
                mail.Subject = "İletişim Formu - Suadiye Hair House";
                mail.IsBodyHtml = true;

                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "mail.kurumsaleposta.com";
                sc.EnableSsl = false;
                sc.Credentials = new NetworkCredential("info@suadiyehairhouse.com.tr", "4Fej4.1:=G=G2Dav");

                var filePath = Path.Combine(_env.WebRootPath, "source", "ContactFormTemplate.html");
                string html = System.IO.File.ReadAllText(filePath);

                html = html.Replace("#name", sendMailDto.Name);
                html = html.Replace("#email",sendMailDto.Email);
                html = html.Replace("#phone",sendMailDto.Phone);
                html = html.Replace("#message", sendMailDto.Message);

                mail.Body = html;

                sc.Send(mail);

                ViewBag.result = true;
                ModelState.Clear();

                ViewBag.Message = "Mesajınız Başarı İle İletildi";

            }
            catch
            {
                ViewBag.result = false;
                ViewBag.Message = "Mesajınız Gönderilemedi Başarı İle İletildi";

                throw;
            }
            return View();
        }


    }
}