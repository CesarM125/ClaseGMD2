using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repository
{
    public class AlumnoRepository
    {
        Contexto context = null;
       
        public AlumnoRepository()
        {
             context = new Contexto();

        }
        public List<Alumno> Listar()
        {

            return context.Alumnos.ToList();

        }
        public Alumno BuscarPorId(int AlumnoId)
        {
            
            Alumno resul = context.Alumnos.Where(s => s.AlumnoId == AlumnoId).FirstOrDefault();
            return resul;

        }

        public int Crear(Alumno alumno)
        {
           Alumno result=  context.Alumnos.Add(alumno);
            context.SaveChanges();
            return result.AlumnoId;
        }

        public bool Editar(Alumno alumno)
        {
            context.Entry(alumno).State = EntityState.Modified;
             context.SaveChanges();
            return true;

        }
        public void Eliminar(int id)
        {

            Alumno result = context.Alumnos.Where(s => s.AlumnoId == id).FirstOrDefault();
            context.Alumnos.Remove(result);
            context.SaveChanges();
           
        }

    }
}
