using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contato(ContatoModel model)
        {
            if (ModelState.IsValid)
            {
                // Configuração do envio de e-mail  
                string toEmail = "messier104ngc4594@gmail.com"; 
                string subject = "Nova Mensagem de Contato via Site";
                string body = $"Nome: {model.Nome}\nEmail: {model.Email}\nAssunto: {model.Assunto}\nMensagem: {model.Mensagem}";

                // Enviar o e-mail  
                using (var message = new MailMessage("messier104ngc4594@gmail.com", toEmail))
                {
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = false;

                    using (var smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com"; 
                        smtp.Port = 587; 
                        smtp.Credentials = new NetworkCredential("messier104ngc4594@gmail.com", "axvz jkoe ptmy iuck"); 
                        smtp.EnableSsl = true;
                        smtp.Send(message);
                    }
                }

                TempData["SuccessMessage"] = "Mensagem enviada com sucesso!";
                ModelState.Clear();
            }

            return View("Index");
        }
    }
}
