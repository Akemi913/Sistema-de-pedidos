using AppEmpleadoC.Entities;
using System.ComponentModel.DataAnnotations;

namespace AppEmpleadoC.Test
{
    public class EmpleadoFormCLSTest
    {
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }

        [Fact]
        public void ValidaCamposVacios()
        {
            var empleado = new EmpleadoFormCLS(); 
            var errores = ValidarModelo(empleado);
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El número de empleado es obligatorio")
                                        || e.ErrorMessage!.Contains("El número de empleado debe ser positivo"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es obligatoria"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota es obligatoria"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Las ventas son obligatorias"));
        }

        [Fact]
        public void ValidarCamposCorrectos()
        {
            var empleado = new EmpleadoFormCLS
            {
                Num_Empl = 1,
                Nombre = "Juan Perez",
                Edad = 30,
                Cargo = "Vendedor",
                FechaContrato = DateTime.Now.Date,
                Cuota = 5000,
                Ventas = 10000
            };

            var errores = ValidarModelo(empleado);
            Assert.Empty(errores); 
        }
    }
}
