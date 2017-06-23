using Prueba.BL.Services;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaWeb.Controllers
{
    public class ClaseController : Controller
    {
        ClaseService service = new ClaseService();

        public ClaseController()
        {
           
        }
        // GET: Clase
        public ActionResult Index()
        {
            List<Clase> lista = service.ListaPersonasContext();//service.ListarClases();
            

            //List<Clase> lista = new List<Clase>();
            //Clase cli1 = new Clase() { ClaseID = 1, Nombre = "Clase1", Comentario = "pruebas" };
            //Clase cli2 = new Clase() { ClaseID = 2, Nombre = "Clase2", Comentario = "pruebas2" };
            // Clase cli3 = new Clase() { ClaseID = 3, Nombre = "Clase3", Comentario = "pruebas3" };
            //lista.Add(cli1);
            //lista.Add(cli2);
            //lista.Add(cli3);
            return View(lista);
        }
    }
}