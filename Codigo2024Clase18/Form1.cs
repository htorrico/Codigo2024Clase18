namespace Codigo2024Clase18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();

            for (int i = 0; i < 20; i++)
            {
                productos.Add(new
                    Producto
                {
                    ProductoID = i,
                    Name = "Nombre",
                    Descripcion = "Descripcion",
                    Precio = 200
                });
            }

            dgvProductos.DataSource = productos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = false;
        }
    }
}
