using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Model
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Cumpleanio { get; set; }
        public string Dni { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}
