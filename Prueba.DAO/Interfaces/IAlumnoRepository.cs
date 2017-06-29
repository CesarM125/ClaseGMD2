using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Interfaces
{
   public  interface IAlumnoRepository
    {
        List<Alumno> Listar();
        Alumno BuscarPorId(int AlumnoId);
        int Crear(Alumno alumno);
        bool Editar(Alumno alumno);
        void Eliminar(int id);
    }
}
