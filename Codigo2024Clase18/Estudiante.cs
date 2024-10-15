using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase18
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public DateTime FechaMatricula { get; set; }
        public bool EsBecado { get; set; }
    }
}
