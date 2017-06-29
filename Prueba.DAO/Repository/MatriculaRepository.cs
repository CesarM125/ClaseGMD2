using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repository
{
   public class MatriculaRepository
    {
        Contexto context = null;

        public MatriculaRepository()
        {
            context = new Contexto();
        }
        public List<Matricula> Listar()
        {
            List<Matricula> lista = new List<Matricula>();
            lista = context.Matriculas.ToList();
            return lista;
        }

        public bool Crear(Matricula matricula)
        {
            try
            {
                Matricula result = context.Matriculas.Add(matricula);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }
    }
}
