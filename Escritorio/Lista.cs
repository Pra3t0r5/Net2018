using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class Lista : Form
    {
        private List<Alumno> listAlumnos = new List<Alumno>();
        private String seleccion;

        public Lista()
        {
            InitializeComponent();

            FillComboBox();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();

            al = listAlumnos.Where(Alumno => Alumno.ApellidoNombre == seleccion).FirstOrDefault();
            MessageBox.Show("Apellido y Nombre: " + al.ApellidoNombre + "\n DNI: " + al.Dni + "\n Fecha de Nacimiento: " + al.FechaNacimiento + "\n Edad: " + al.Edad + "\n Email: " + al.Email + "\n ID: " + al.id, "Detalles del Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FillComboBox()
        {
            
            List<String> listNomyAp = new List<String>();

            listAlumnos = AlumnoLogic.RecuperarTodos();

            listNomyAp = listAlumnos.Select(Alumno => Alumno.ApellidoNombre).ToList();
            listNomyAp.Sort();

            this.cbApeyNom.DataSource = listNomyAp;
        }

        private void cbApeyNom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            seleccion = this.cbApeyNom.GetItemText(this.cbApeyNom.SelectedItem);
        }
    }
}
