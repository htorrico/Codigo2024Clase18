using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase18
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

    }
}
