using System.ComponentModel.DataAnnotations;

namespace AppEmpleadoC.Entities
{
    public class EmpleadoFormCLS
    {
        [Required(ErrorMessage = "El número de empleado es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de empleado debe ser positivo")]
        public int Num_Empl { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Range(18, 100, ErrorMessage = "La edad debe ser mayor o igual a 18")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio")]
        [MaxLength(50, ErrorMessage = "El cargo no puede superar los 50 caracteres")]
        public string Cargo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de contrato es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Debe ingresar una fecha válida")]
        public DateTime FechaContrato { get; set; }

        [Required(ErrorMessage = "La cuota es obligatoria")]
        [Range(0, double.MaxValue, ErrorMessage = "La cuota debe ser un número válido")]
        public decimal Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas son obligatorias")]
        [Range(0, double.MaxValue, ErrorMessage = "Las ventas deben ser un número válido")]
        public decimal Ventas { get; set; }
        public int CodigoSucursal { get; set; }
        public string Ciudad { get; set; } = string.Empty;
        public int idDirector { get; set; } 
        public string NombreDirector { get; set; } = string.Empty;
    }
}
