using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using YouLook_Official.Models;

namespace YouLook_Official.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sendmail(ContactFormModel model)
        {

            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(model.Email);
                mail.From = new MailAddress("hlong24399@gmail.com");
                mail.Subject = model.Subject;
                mail.Body = model.Message;
                mail.IsBodyHtml = true;
                if (model.FormFile != null)
                {
                    
                    mail.Attachments.Add(new Attachment(model.FormFile.OpenReadStream(), model.FormFile.FileName));
                }

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("hlong24399@gmail.com", "John1Touch");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                ViewBag.Confirm = "Your email is sent!";
                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
