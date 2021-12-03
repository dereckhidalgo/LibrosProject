using Librería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Librería.Controllers
{
    public class FacturasController : Controller
    {
        LibrosProyectoEntities bd = new LibrosProyectoEntities();
        // GET: Facturas
        public ActionResult Index()
        {
            return View(bd.factura.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        [HttpPost]
        public ActionResult Create(factura collection)
        {
            try
            {
                // TODO: Add insert logic here
                bd.factura.Add(collection);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
