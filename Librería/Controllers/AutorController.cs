using Librería.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Librería.Controllers
{
    public class AutorController : Controller
    {
        LibrosProyectoEntities bd = new LibrosProyectoEntities();

        public ActionResult Index()
        {
            return View(bd.autor.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            autor autor = bd.autor.FirstOrDefault(a => a.idAutor == id);
            return View(autor);
        }
        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(autor autor)
        {
            try
            {
                // TODO: Add insert logic here
                bd.autor.Add(autor);
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
            autor autor = bd.autor.FirstOrDefault(a => a.idAutor== id);
            return View(autor);
        }

        // POST: Libros/Edit/5
        [HttpPost]
        public ActionResult Edit(autor autor)
        {
            try
            {
                // TODO: Add update logic here
                autor aut = bd.autor.FirstOrDefault(a => a.idAutor == autor.idAutor);
                aut.nombreAutor= autor.nombreAutor;
                aut.apellidoAutor = autor.apellidoAutor;
                aut.edad= autor.edad;
                aut.pais= autor.pais;
                aut.estado = autor.estado;
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
            autor autor = bd.autor.FirstOrDefault(a => a.idAutor== id);

            return View(autor);
        }

        // POST: Libros/Delete/5
        [HttpPost]
        public ActionResult Delete(autor autor)
        {
            try
            {
                autor aut = bd.autor.FirstOrDefault(a => a.idAutor== autor.idAutor);
                // TODO: Add delete logic here
                bd.autor.Remove(aut);
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
