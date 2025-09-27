using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleadosC.Entities
{
    public class EmpleadoListCLS
    {
        public int Num_Empl { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public int CodigoSucursal { get; set; }
        public string Ciudad { get; set; } = null!;
        public int idDirector { get; set; }
        public string NombreDirector { get; set; } = null!;
    }
}
