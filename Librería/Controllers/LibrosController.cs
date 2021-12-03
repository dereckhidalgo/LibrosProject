using Librería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Librería.Controllers
{
    public class LibrosController : Controller
    {
        LibrosProyectoEntities bd = new LibrosProyectoEntities();
 
        public ActionResult Index()
        {
            return View(bd.libros.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
          libros libro =  bd.libros.FirstOrDefault(a => a.idLibros == id);
           return View(libro);
        }
        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(libros libro)
        {
            try
            {
                // TODO: Add insert logic here
                bd.libros.Add(libro);
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
            libros libro = bd.libros.FirstOrDefault(a => a.idLibros == id);
            return View(libro);
        }

        // POST: Libros/Edit/5
        [HttpPost]
        public ActionResult Edit(libros libro)
        {
            try
            {
                // TODO: Add update logic here
                libros lib = bd.libros.FirstOrDefault(a => a.idLibros == libro.idLibros);
                lib.idAutor = libro.idAutor;
                lib.idEditorial = libro.idEditorial;
                lib.nombreLibro = libro.nombreLibro;
                lib.precioLibro = libro.precioLibro;
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
            libros lib = bd.libros.FirstOrDefault(a => a.idLibros == id);

            return View(lib);
        }

        // POST: Libros/Delete/5
        [HttpPost]
        public ActionResult Delete(libros libro)
        {
            try
            {
                libros libre = bd.libros.FirstOrDefault(a => a.idLibros == libro.idLibros);
                // TODO: Add delete logic here
                bd.libros.Remove(libre);
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
