using Librería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Librería.Controllers
{
    public class EditorialController : Controller
    {
        LibrosProyectoEntities bd = new LibrosProyectoEntities();

        public ActionResult Index()
        {
            return View(bd.editorial.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            editorial autor = bd.editorial.FirstOrDefault(a => a.idEditorial== id);
            return View(autor);
        }
        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(editorial editorial)
        {
            try
            {
                // TODO: Add insert logic here
                bd.editorial.Add(editorial);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            editorial editorial = bd.editorial.FirstOrDefault(a => a.idEditorial == id);
            return View(editorial);
        }

        // POST: Libros/Edit/5
        [HttpPost]
        public ActionResult Edit(editorial editorial)
        {
            try
            {
                // TODO: Add update logic here
                editorial edit = bd.editorial.FirstOrDefault(a => a.idEditorial== editorial.idEditorial);
                edit.nombreEditorial = editorial.nombreEditorial;
                edit.direccionEditorial = editorial.direccionEditorial;
                edit.descripcion = editorial.descripcion;
                edit.telefono = editorial.telefono;
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            editorial editorial= bd.editorial.FirstOrDefault(a => a.idEditorial == id);

            return View(editorial);
        }

        // POST: Libros/Delete/5
        [HttpPost]
        public ActionResult Delete(editorial editorial)
        {
            try
            {
                editorial edit = bd.editorial.FirstOrDefault(a => a.idEditorial== editorial.idEditorial);
                // TODO: Add delete logic here
                bd.editorial.Remove(editorial);
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
