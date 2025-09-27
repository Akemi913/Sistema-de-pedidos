using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleadosC.Entities
{
    public class SucursalCLS
    {
        public int CodigoSucursal { get; set; }
        public string Ciudad { get; set; } = null!;
        public string Region { get; set; } = null!;
        public int Num_Empl_Director { get; set; }
        public string NombreDirector { get; set; } = null!;
        public decimal ObjetivoVenta { get; set; }
        public decimal VentasReales { get; set; }
    }
}
