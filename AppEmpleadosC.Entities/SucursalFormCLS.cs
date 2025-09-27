using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleadosC.Entities
{
    public class SucursalFormCLS
    {
        [Required(ErrorMessage = "El código de sucursal es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El código de sucursal debe ser positivo.")]
        public int CodigoSucursal { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria.")]
        [MaxLength(100, ErrorMessage = "La ciudad no puede superar los 100 caracteres.")]
        public string Ciudad { get; set; } = string.Empty;

        [Required(ErrorMessage = "La región es obligatoria.")]
        [MaxLength(50, ErrorMessage = "La región no puede superar los 50 caracteres.")]
        public string Region { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe asignar un director.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un director válido.")]
        public int Num_Empl_Director { get; set; }

        [Required(ErrorMessage = "El objetivo de venta es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El objetivo de venta debe ser un valor positivo.")]
        public decimal ObjetivoVenta { get; set; }

        [Required(ErrorMessage = "Las ventas reales son obligatorias.")]
        [Range(0, double.MaxValue, ErrorMessage = "Las ventas reales deben ser un valor positivo.")]
        public decimal VentasReales { get; set; }
    }
}
