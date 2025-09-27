using System.ComponentModel;
using AppEmpleadosC.Entities;
namespace AppEmpleadoC.Client.Services
{
    public class SucursalService
    {
        private readonly EmpleadoService _empleadoService;
        private List<SucursalCLS> lista;
        public event Func<string, Task> OnSearch = delegate { return Task.CompletedTask; };
        public async Task notificarBusqueda(string nombre)
        {
            await OnSearch.Invoke(nombre);
        }
        public SucursalService(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
            lista = new List<SucursalCLS>
            {
                new SucursalCLS
                {
                    CodigoSucursal = 1,
                    Ciudad = "La Paz",
                    Region = "Andina",
                    Num_Empl_Director = 1,
                    NombreDirector = "Juan Perez",
                    ObjetivoVenta = 500000,
                    VentasReales = 450000
                },
                new SucursalCLS
                {
                    CodigoSucursal = 2,
                    Ciudad = "Santa Cruz",
                    Region = "Llanos Orientales",
                    Num_Empl_Director = 2,
                    NombreDirector = "Rosa Mamani",
                    ObjetivoVenta = 800000,
                    VentasReales = 850000
                },
                new SucursalCLS
                {
                    CodigoSucursal = 3,
                    Ciudad = "Cochabamba",
                    Region = "Valles",
                    Num_Empl_Director = 3,
                    NombreDirector = "Julian Apaza",
                    ObjetivoVenta = 600000,
                    VentasReales = 580000
                }
            };
            
        }
        public List<SucursalCLS> listarSucursal()
        {
            return lista;
        }
        public List<SucursalCLS> filtrarSucursales(string ciudad)
        {
            if (ciudad == "")
            {
                return listarSucursal();
            }
            else
            {
                return listarSucursal().Where(s => s.Ciudad.ToUpper().Contains(ciudad.ToUpper())).ToList();
            }
        }
        public void eliminarSucursal(int codigoSucursal)
        {
            var listaQueda = lista.Where(x => x.CodigoSucursal != codigoSucursal).ToList();
            lista = listaQueda;
        }

        public SucursalFormCLS recuperarSucursalPorId(int codigoSucursal)
        {
            var obj = lista.Where(s => s.CodigoSucursal == codigoSucursal).FirstOrDefault();
            if (obj != null)
            {
                return new SucursalFormCLS
                {
                    CodigoSucursal = obj.CodigoSucursal,
                    Ciudad = obj.Ciudad,
                    Region = obj.Region,
                    Num_Empl_Director = obj.Num_Empl_Director,
                    ObjetivoVenta = obj.ObjetivoVenta,
                    VentasReales = obj.VentasReales
                };
            }
            else
            {
                return new SucursalFormCLS();
            }
        }
        public void guardarSucursal(SucursalFormCLS oSucursalFormCLS)
        {
            var director = _empleadoService.listarEmpleados().FirstOrDefault(e => e.Num_Empl == oSucursalFormCLS.Num_Empl_Director);
            string nombreDirector = director?.Nombre ?? "Sin Director";
            lista.Add(new SucursalCLS
            {
                CodigoSucursal = oSucursalFormCLS.CodigoSucursal,
                Ciudad = oSucursalFormCLS.Ciudad,
                Region = oSucursalFormCLS.Region,
                Num_Empl_Director = oSucursalFormCLS.Num_Empl_Director,
                NombreDirector = nombreDirector,
                ObjetivoVenta = oSucursalFormCLS.ObjetivoVenta,
                VentasReales = oSucursalFormCLS.VentasReales
            });
        }
    }
}
