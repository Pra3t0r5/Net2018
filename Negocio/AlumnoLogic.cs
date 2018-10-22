using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AlumnoLogic
    {
        public static List<Alumno> RecuperarTodos()
        {
            AlumnoAdapter DatosAlumnos = new AlumnoAdapter();
            return DatosAlumnos.RecuperarTodos();
        }
    }
}
