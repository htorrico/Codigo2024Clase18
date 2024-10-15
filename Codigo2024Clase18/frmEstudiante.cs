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
            estudiantesBinding.RemoveAt(elementoFinal - 1);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(estudiantesBinding.Count.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estudiantesBinding.Count == 3)
            {
                timer1.Stop();
            }
            MessageBox.Show(estudiantesBinding.Count.ToString());
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            timerHora.Start();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            LBLHORA.Text=DateTime.Now.ToLocalTime().ToString();
        }
    }
}
