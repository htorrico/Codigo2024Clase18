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

        BindingList<Estudiante> estudiantesBinding = new BindingList<Estudiante>();

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
                    EstudianteID = estudiantes.Count + 1,
                    Apellidos = apellidos,
                    Nombres = nombres,
                    EsBecado = esBecado,
                    FechaMatricula = fechaMatricula
                });

                Limpiar();
                MessageBox.Show("Registro Exitoso");
                Listar();
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
            Listar();
        }

        void Limpiar()
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            chkBecado.Checked = false;
            dtpFechaMatricula.Value = DateTime.Now;

        }
        void Listar()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnBinding_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = estudiantesBinding;
        }

        private void btnAgregarBinding_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaMatricula = dtpFechaMatricula.Value;
                bool esBecado = chkBecado.Checked;

                estudiantesBinding.Add(new Estudiante
                {
                    EstudianteID = estudiantesBinding.Count + 1,
                    Apellidos = apellidos,
                    Nombres = nombres,
                    EsBecado = esBecado,
                    FechaMatricula = fechaMatricula
                });


                Limpiar();
                MessageBox.Show("Registro Exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Comunicarse con el administrador");
                //throw ex;
            }

        }

        private void btnEliminarBinding_Click(object sender, EventArgs e)
        {
            int elementoFinal = estudiantesBinding.Count;
            estudiantesBinding.RemoveAt(elementoFinal-1);
        }
    }
}
