using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {

        /// <summary></summary>
        public String ApellidoNombre
        {
            get => default(String);
            set
            {
            }
        }

        public String Dni
        {
            get => default(String);
            set
            {
            }
        }

        

        public String Email
        {
            get => default(String);
            set
            {
            }
        }

        public DateTime FechaNacimiento
        {
            get => default(DateTime);
            set
            {
            }
        }

        public decimal NotaPromedio
        {
            get => default(int);
            set
            {
            }
        }

        public int Edad
        {
            get => DateTime.Today.Year - FechaNacimiento.Year;
            set
            {
            }
        }

        public int id { get; set; }

        public Alumno()
        {
            
        }

        public Alumno(int id, String dni, String apellidonom, DateTime fechaNac, String email, decimal notaProm)
        {
            this.id = id;
            this.ApellidoNombre = apellidonom;
            this.Dni = dni;
            this.FechaNacimiento = fechaNac;
            this.Email = email;
            this.NotaPromedio = notaProm;
        }    
    }
}

