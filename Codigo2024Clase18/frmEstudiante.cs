using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo2024Clase18
{
    public partial class frmEstudiante : Form
    {
        //BindingList
        List<Estudiante> estudiantes = new List<Estudiante>();
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaMatricula = dtpFechaMatricula.Value;
                bool esBecado = chkBecado.Checked;

                estudiantes.Add(new Estudiante
                {
                    EstudianteID=estudiantes.Count+1,
                    Apellidos = apellidos,
                    Nombres = nombres,
                    EsBecado = esBecado,
                    FechaMatricula = fechaMatricula
                });
               


                MessageBox.Show("Registro Exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Comunicarse con el administrador");
                //throw ex;
            }
           
            //dgvEstudiantes.Rows.Add( nombres,apellidos,fechaMatricula,esBecado);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = null;
            
            dgvEstudiantes.DataSource = estudiantes;
        }
    }
}
