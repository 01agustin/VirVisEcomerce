using Microsoft.AspNetCore.Mvc;
using VirVisEcomerce.Context;
using VirVisEcomerce.Models;

namespace VirVisEcomerce.Controllers
{
    public class RegisterController : Controller
    {
        private readonly VirVisEcomerceContext _context;

        public RegisterController(VirVisEcomerceContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var existingUser = _context.Usuario.FirstOrDefault(u => u.email == model.email);
                if (existingUser != null)
                {
                    model.emailError = "El correo electrónico ya está registrado.";
                    return View(model);
                }

                var newUser = new Usuario
                {
                    name = model.name,
                    lastname = model.lastname,
                    email = model.email,
                    password = model.password,
                    role = "user"
                    // que onda aca el rol?
                };

                _context.Usuario.Add(newUser);

                _context.SaveChanges();

                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }

   
    }
}
