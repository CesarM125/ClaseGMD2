using Prueba.DAO.Repository;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
   public   class ClaseService
    {
        ClaseRepository repository = new ClaseRepository();
        public ClaseService()
        {

        }

        public List<Clase> ListarClases3()
        {
            List<Clase> lista = new List<Clase>();
              lista=   repository.ListaPersonas();
            return lista;
        }

        public List<Clase> ListaPersonasContext()
        {
            List<Clase> lista = new List<Clase>();
            lista = repository.ListaPersonasContext();
            return lista;
        }
        
        public List<Clase> ListarClases2()
        {

             List< Clase > lista = new List<Clase>();
            Clase cli1 = new Clase() { ClaseID = 1, Nombre = "Clase1", Comentario = "pruebas" };
            Clase cli2 = new Clase() { ClaseID = 2, Nombre = "Clase2", Comentario = "pruebas2" };
            Clase cli3 = new Clase() { ClaseID = 3, Nombre = "Clase3", Comentario = "pruebas3" };
            lista.Add(cli1);
            lista.Add(cli2);
            lista.Add(cli3);

            return lista;
        }
    }
}
