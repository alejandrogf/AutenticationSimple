using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutenticationSimple.Models;

namespace AutenticationSimple.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Usuario modeloUsuario)
        {
            
            if (modeloUsuario.Login == modeloUsuario.Password)
            {
                //Aquí pasas el nombre del usuario.
                var identidad=new GenericIdentity(modeloUsuario.Login);
                //Se asigna el rol o roles que tiene el usuario.
                //En este caso se asigna a mano. El rol se llama usuario, como puede ser perico
                //Aqui creas un array donde el usuario (identidad) tiene un array 
                //con uno o varios roles(usuario, admin, etc
                var principal=new GenericPrincipal(identidad, new []{"usuario", "miron"});
                //Accedes al hilo actual que está ejecutando la aplicación y se fuerza la creación
                //de la cookie de autenticación para q mantenga los datos
                Thread.CurrentPrincipal = principal;
                FormsAuthentication.SetAuthCookie(modeloUsuario.Login, false);
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("error","Autenticación incorrecta");
            return View(modeloUsuario);
        }
    }
}