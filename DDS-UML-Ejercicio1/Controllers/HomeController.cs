using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio1.Models;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection busqueda)
        {

            Control control = new Control();

            int cantidadCuentas = control.getCliente(int.Parse(busqueda["dni"]), int.Parse(busqueda["saldo"]));

            ViewBag.Result = "El cliente con DNI " + busqueda["dni"] + " tiene " +cantidadCuentas+ " cuentas con un saldo mayor a $" + busqueda["saldo"];


            return View();
        }
    }
}