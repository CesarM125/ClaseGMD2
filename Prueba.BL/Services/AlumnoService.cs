using Prueba.DAO.Repository;
using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
   public class AlumnoService
    {
        AlumnoRepository repositorio = null;
        public AlumnoService()
        {
             repositorio = new AlumnoRepository();
        }
        public List<Alumno> Listar()
        { 

            return repositorio.Listar();
        }

        public Alumno BuscarPorId(int AlumnoId)
        {
            return repositorio.BuscarPorId(AlumnoId);
        }

        public Boolean Crear(Alumno alumno)
        {
            int result = repositorio.Crear(alumno);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public bool Editar(Alumno alumno)
        {
            Alumno sinCambios = repositorio.BuscarPorId(alumno.AlumnoId);
            sinCambios.Apellido = alumno.Apellido;
            sinCambios.Nombre = alumno.Nombre;
            sinCambios.Cumpleanio = alumno.Cumpleanio;
            return repositorio.Editar(sinCambios);

        }
        public void Eliminar(int id)
        {
            repositorio.Eliminar(id);
        }
    }
}
