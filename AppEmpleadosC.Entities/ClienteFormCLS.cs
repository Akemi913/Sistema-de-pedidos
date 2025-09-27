using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AppEmpleadosC.Entities
{
    public class ClienteFormCLS
    {
        [Required(ErrorMessage = "El número de cliente es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de cliente debe ser positivo")]
        public int CodigoCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        public string NombreCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe tener un Representante de Ventas asignado")]
        [MaxLength(50, ErrorMessage = "El cargo no puede superar los 50 caracteres")]
        public string Representante { get; set; } = string.Empty;

        [Required(ErrorMessage = "El limite de credito es obligatotio")]
        [Range(0, double.MaxValue, ErrorMessage = "El limite de redito es obligatorio")]
        public decimal LimiteCredito { get; set; }

        public int Num_Empl { get; set; }


    }
}
