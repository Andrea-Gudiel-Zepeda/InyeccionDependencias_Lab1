using InyeccionDependencias_MVC_Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InyeccionDependencias_MVC_Lab1.Controllers
{
    public class HomeController : Controller
    {
        
        Biblioteca _biblioteca = new Biblioteca();

        private readonly ISingleton _singleton;
        private readonly ITransient _transient;
        private readonly ITransient _transient1;
        private readonly ITransient _transient2;
        private readonly ITransient _transient3;
        private readonly ITransient _transient4;
        private readonly IScoped _scoped;

        public HomeController(ISingleton singleton, ITransient transient, ITransient transient1, ITransient transient2, 
             ITransient transient3, ITransient transient4, ISingleton singleton2, IScoped scoped)
        {
            _singleton = singleton;
            _transient = transient;
            _transient1 = transient1;
            _transient2 = transient2;
            _transient3 = transient3;
            _transient4 = transient4;
            _scoped = scoped;
        }

        public IActionResult Index()
        {
            _transient.datos("Alice Kellen", "El mapa de los anhelos");
            _transient1.datos("Christina Hobbs", "Una luna sin miel");
            _transient2.datos("Hanya Yanagihara", "Tan poca vida");
            _transient3.datos("Sarah J. Mass", "Una corte de niebla y furia");
            _transient4.datos("Elisabet Benavet", "Un cuento perfecto");

            ViewBag.Singleton = _singleton;
            ViewBag.Transient = _transient;
            ViewBag.Transient1 = _transient1;
            ViewBag.Transient2 = _transient2;
            ViewBag.Transient3 = _transient3;
            ViewBag.Transient4 = _transient4;
            ViewBag.Scoped = _scoped;


            return View();
        }

    }
}