using Librería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Librería.Controllers
{
    public class HomeController : Controller
    {
        LibrosProyectoEntities bd = new LibrosProyectoEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string message = "")
        {
            ViewBag.message = message;
            return View();
        }

        [HttpPost]
        public ActionResult LoginAut(string userName, string pswrd)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(pswrd)) 
            {
                usuario user = bd.usuario.FirstOrDefault(a => a.userName == userName && a.pswrd == pswrd);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.nombreDelUsuario, true);
                    return RedirectToAction("Index","Libros");
                }
                else
                {
                    return RedirectToAction("Login", new { message = "Credenciales incorrectas" });
                }
            }
            else
            {
                return RedirectToAction("Login", new { message = "Todos los campos son obligatorios" });
            }
            
       }
    }
}