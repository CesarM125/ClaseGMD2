using Prueba.DAO.Repository;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
   public class MatriculaService
    {
        MatriculaRepository repository = null;
        public MatriculaService()
        {
            repository = new MatriculaRepository();
        }

        public List<Matricula> Listar()
        {
            return repository.Listar();
        }

        public bool Crear(Matricula matricula)
        {
          return  repository.Crear(matricula); 
        }
    }
}
