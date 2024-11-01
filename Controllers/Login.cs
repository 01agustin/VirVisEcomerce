using Microsoft.AspNetCore.Mvc;
using VirVisEcomerce.Context;
using VirVisEcomerce.Models;

namespace VirVisEcomerce.Controllers
{
    public class Login : Controller
    {
        private readonly VirVisEcomerceContext _context;

        public Login(VirVisEcomerceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
         
                if (AuthenticateUser(model.email, model.password))
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email de usuario o contraseña incorrectos.");
                }
            }
            return View(model);
        }

        private bool AuthenticateUser(string email, string password)
        {
            var usuario = _context.Usuario.SingleOrDefault(u => u.email == email && u.password == password);

            return usuario != null; 
        }
    }
}
