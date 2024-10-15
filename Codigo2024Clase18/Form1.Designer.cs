namespace Codigo2024Clase18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            NombreColumna = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnListar = new Button();
            dgvAlmacen = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            PrecioAlmacen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacen).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { NombreColumna, Precio, Descripcion });
            dgvProductos.Location = new Point(30, 199);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(434, 211);
            dgvProductos.TabIndex = 0;
            // 
            // NombreColumna
            // 
            NombreColumna.DataPropertyName = "Name";
            NombreColumna.HeaderText = "Nombre";
            NombreColumna.MinimumWidth = 6;
            NombreColumna.Name = "NombreColumna";
            NombreColumna.Width = 125;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(646, 109);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(133, 53);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvAlmacen
            // 
            dgvAlmacen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlmacen.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Ubicacion, PrecioAlmacen });
            dgvAlmacen.Location = new Point(493, 199);
            dgvAlmacen.Name = "dgvAlmacen";
            dgvAlmacen.RowHeadersWidth = 51;
            dgvAlmacen.Size = new Size(434, 211);
            dgvAlmacen.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Ubicacion
            // 
            Ubicacion.DataPropertyName = "Ubicacion";
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.MinimumWidth = 6;
            Ubicacion.Name = "Ubicacion";
            Ubicacion.Width = 125;
            // 
            // PrecioAlmacen
            // 
            PrecioAlmacen.DataPropertyName = "Precio";
            PrecioAlmacen.HeaderText = "Precio";
            PrecioAlmacen.MinimumWidth = 6;
            PrecioAlmacen.Name = "PrecioAlmacen";
            PrecioAlmacen.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(dgvAlmacen);
            Controls.Add(btnListar);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnListar;
        private DataGridViewTextBoxColumn NombreColumna;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridView dgvAlmacen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn PrecioAlmacen;
    }
}
