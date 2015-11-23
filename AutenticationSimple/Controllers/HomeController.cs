using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutenticationSimple.Controllers
{
    //Con este atributo se indica que todos lo que hay en el controller, está protegido
    //por autorización y por tanto si no estás autorizado, no puedes acceder ni
    //ejecutar nada de aquí
    [Authorize(Roles = "miron")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}