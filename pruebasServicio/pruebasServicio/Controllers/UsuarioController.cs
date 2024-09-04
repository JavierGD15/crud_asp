using Microsoft.AspNetCore.Mvc;
using pruebasServicio.Models;
using pruebasServicio.Service;

namespace pruebasServicio.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public IActionResult Index()
        {
            return View();
        }

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }


        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioService.RegistrarUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}
