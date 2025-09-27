using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleadosC.Entities
{
    public class ClienteListCLS
    {
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string Representante { get; set; } = null!;
        public int Num_Empl { get; set; }
        public decimal LimiteCredito { get; set; } 
    }
}
