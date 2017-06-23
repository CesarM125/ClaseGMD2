using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repository
{
    public class ClaseRepository
    {
        Contexto contexto = new Contexto();

        public ClaseRepository()
        {
           

        }
        public List<Clase> ListaPersonasContext()
        {
            List<Clase> lista = new List<Clase>();
            lista = contexto.Clases.ToList();
            return lista;
        }
        public List<Clase> ListaPersonas()
        {
            List<Clase> lista = new List<Clase>();
            Clase cli1 = new Clase() { ClaseID = 1, Nombre = "Clase10", Comentario = "pruebas" };
            Clase cli2 = new Clase() { ClaseID = 2, Nombre = "Clase20", Comentario = "pruebas2" };
            Clase cli3 = new Clase() { ClaseID = 3, Nombre = "Clase30", Comentario = "pruebas3" };
            lista.Add(cli1);
            lista.Add(cli2);
            lista.Add(cli3);

            return lista;

            
        }
    }
}
