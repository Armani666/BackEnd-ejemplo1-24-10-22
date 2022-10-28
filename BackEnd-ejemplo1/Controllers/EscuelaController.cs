using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_ejemplo1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            ViewBag.Nombre = "Eduardo Tomas";
            ViewBag.correo = "eduardo@gmail.com";
            ViewBag.Fecha = new DateTime(2001, 12, 10);
            return View();
        }

        public ActionResult index2()
        {
            ViewData["Nombre"] = "Ramses";
            ViewData["correo"] = "19002573@alumnos.utleon.edu.mx";
            ViewData["FechaNaci"] = new DateTime(1999, 08, 27);
            return View();
        }

        public ActionResult Agregar(Trabajador emp)
        {

            return View(emp);
        }
        public ActionResult Agregar2(Trabajador emp)
        {
            var trab = new Trabajador()
            {
                Nombre = "Ulises",
                Apellidos = "Cardona",
                FechaNacimiento = new DateTime(2000, 1, 1),
                Sueldo = 250,
                EsFijo = true
            };
            ViewBag.Trabajador = trab;
            return View(emp);
        
        }
    }
}