using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class AlumnoAdapter : Adapter
    {
        public List<Alumno> RecuperarTodos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                OpenConnection();
                SqlCommand cmdAlum = new SqlCommand("SELECT * FROM ALUMNOS", connString);
                SqlDataReader dr = cmdAlum.ExecuteReader();
                {
                    while (dr.Read())
                    {
                        Alumno al = new Alumno();

                        al.ApellidoNombre = (String)dr["apellidonombre"];
                        al.id = (int)dr["id"];
                        al.NotaPromedio = (decimal)dr["notapromedio"];
                        al.Email = (String)dr["email"];
                        al.Dni = (String)dr["dni"];
                        al.FechaNacimiento = (DateTime)dr["fechanacimiento"];

                        alumnos.Add(al);

                    }
                }
                dr.Close();
                CloseConnection();
                return alumnos;
            }
            catch(Exception ex)
            {
                Exception ec = new Exception("Error recuperando", ex);
                throw ec;
            }
            
        }
    }




    /*class AlumnoAdapter : Adapter
    {
        public List<Alumno> RecuperarTodos()
        {
            List<Alumno> Alumnos = new List<Alumno>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM ALUMNOS", connString);
                SqlDataReader dr = cmdAlumnos.ExecuteReader();
                while(dr.Read())
                {
                    Alumno al = new Alumno();
                    al.ApellidoNombre = (String)dr["apellidonombre"];
                    al.id = (int)dr["id"];
                    al.NotaPromedio = (decimal)dr["notapromedio"];
                    al.Email = (String)dr["email"];
                    al.Dni = (String)dr["dni"];
                    al.FechaNacimiento = (DateTime)dr["fechanacimiento"];

                    Alumnos.Add(al);                    
                }
                dr.Close();
                this.CloseConnection();
            }
            catch(Exception ex)
            {
                Exception exContr = new Exception("Error al recuperar alumnos", ex);
                throw exContr;
            }

            return Alumnos;
        }
    }*/
}
