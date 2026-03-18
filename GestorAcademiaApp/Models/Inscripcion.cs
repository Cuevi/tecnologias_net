using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Models
{
    internal class Inscripcion
    {
        public string emailAlumno {  get; set; }
        public string nombreCurso { get; set; }
        public DateTime fechaInscripcion {get; set; } 
        public DateTime fechaLimiteEntrega {  get; set; }

        public Inscripcion(string emailAlumno, string nombreCurso, DateTime fechaInscripcion, DateTime fechaLimiteEntrega)
        {
            this.emailAlumno = emailAlumno;
            this.nombreCurso = nombreCurso;
            this.fechaInscripcion = fechaInscripcion;
            this.fechaLimiteEntrega = fechaLimiteEntrega;
        }
    }
}
