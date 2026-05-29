using Microsoft.AspNetCore.Mvc;

namespace Bibliotec_MVC_DEV.Controllers
{
    public class LivroController : Controller
    {
       
        public IActionResult Index()
        {
            string? adminSessao = HttpContext.Session.GetString("Admin");

            if (adminSessao == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Admin = adminSessao == "True" || adminSessao == "true";

            return View();
        }
    }
}