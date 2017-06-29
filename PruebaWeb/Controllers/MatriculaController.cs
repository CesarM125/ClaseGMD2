using Prueba.BL.Services;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaWeb.Controllers
{
    public class MatriculaController : Controller
    {
        MatriculaService service = null;
        AlumnoService serviceAlumno = null;
        public MatriculaController()
        {
            service = new MatriculaService();
            serviceAlumno = new AlumnoService();
        }
        // GET: Matricula

        public ActionResult Index(int id)
        {
            //List<Matricula> lista = service.Listar();
            List<Matricula> lista = service.ListadoPorAlumno(id);
            Alumno alumno = serviceAlumno.BuscarPorId(id);
            ViewBag.NombreAlumno = alumno.Apellido + " " + alumno.Nombre;

            ViewBag.AlumnoId = id;
            return View(lista);
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matricula/Create
        public ActionResult Crear(int idalumno)
        {
            Matricula matricula = new Matricula();
            matricula.AlumnoId = idalumno;
           // ViewBag.AlumnoId = idalumno;
            return View(matricula);
            //bool resultado = service.Crear(matriculas);
            //if (resultado)
            //  return  RedirectToAction("Index");
            //else

            
        }

        // POST: Matricula/Create
        [HttpPost]
        public ActionResult Crear(Matricula matricula)
        {
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            bool resultado = service.Crear(matricula);
            if (resultado)
                return RedirectToAction("Index", new { id=matricula.AlumnoId});
            else

                return View(matricula);
        }

        // GET: Matricula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matricula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matricula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matricula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
