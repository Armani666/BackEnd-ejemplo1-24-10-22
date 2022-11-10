using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd_ejemplo1.Models;

namespace BackEnd_ejemplo1.Controllers
{
    public class VisParCochesController : Controller
    {
        // GET: VisParCoches
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _Garage()
        {
            return View("_Garage", new Garage());
        }
        public ActionResult _GarageSimple()
        {
            return View("_GarageSimple", new Garage());
        }
       
    }
}