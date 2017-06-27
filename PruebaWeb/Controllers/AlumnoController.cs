using Prueba.BL.Services;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaWeb.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        AlumnoService service = null;
        public AlumnoController()
        {
             service = new AlumnoService();
        }
        public ActionResult Index()
        {
            
            List<Alumno> result = service.Listar();

            return View(result);
        }

        [HttpGet]
        public ActionResult Crear()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Crear(Alumno alumno)
        {
            if (service.Crear(alumno))
            
              return   RedirectToAction("Index");
            
                return View(alumno);
            
        

        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
         Alumno alumno = service.BuscarPorId(id);

            return View(alumno);

        }

        [HttpPost]
        public ActionResult Editar(Alumno alumno)
        {
            service.Editar(alumno);
            return RedirectToAction("Index");

        }
    }
}