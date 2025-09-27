using AppEmpleadosC.Entities;
namespace AppEmpleadoC.Client.Services
{
    public class ClienteService
    {
        private readonly EmpleadoService _empleadoService;
        public event Func<string, Task> OnSearch = delegate { return Task.CompletedTask; };
        private List<ClienteListCLS> lista;
        public ClienteService(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
            lista = new List<ClienteListCLS>
            {
                new ClienteListCLS { CodigoCliente = 1, NombreCliente = "Carlos Lopez", Representante = "Juan Perez", Num_Empl = 1, LimiteCredito = 5000 },
                new ClienteListCLS { CodigoCliente = 2, NombreCliente = "Ana Gomez", Representante = "Rosa Mamani", Num_Empl = 2, LimiteCredito = 10000 },
                new ClienteListCLS { CodigoCliente = 3, NombreCliente = "Luis Martinez", Representante = "Julian Apaza", Num_Empl = 3, LimiteCredito = 7500 }
            };
        }
        public async Task notificarBusqueda(string NombreCliente)
        {
            await OnSearch.Invoke(NombreCliente);
        }
        public List<ClienteListCLS> listarClientes()
        {
            return lista;
        }
        public List<ClienteListCLS> filtrarClientes(string NombreCliente)
        {
            List<ClienteListCLS> l = listarClientes();
            if (NombreCliente == "")
            {
                return l;
            }
            else
            {
                List<ClienteListCLS> listafiltrada = l.Where(p => p.NombreCliente.ToUpper().Contains(NombreCliente.ToUpper())).ToList();
                return listafiltrada;
            }

        }

        public void eliminarCliente(int CodigoCliente)
        {
            var listaQueda = lista.Where(x => x.CodigoCliente != CodigoCliente).ToList();
            lista = listaQueda;
        }
        public ClienteFormCLS recuperarClientePorId(int CodigoCliente)
        {
            var obj = lista.Where(p => p.CodigoCliente == CodigoCliente).FirstOrDefault();
            if (obj != null)
            {
                return new ClienteFormCLS { CodigoCliente = obj.CodigoCliente, NombreCliente = obj.NombreCliente, Representante = obj.Representante, Num_Empl = obj.Num_Empl, LimiteCredito = obj.LimiteCredito };
            }
            else
            {
                return new ClienteFormCLS();
            }
        }
        public void guardarCliente(ClienteFormCLS oClienteFormCLS)
        {
            var empleado = _empleadoService.listarEmpleados().FirstOrDefault(e => e.Num_Empl == oClienteFormCLS.Num_Empl);
            lista.Add(new ClienteListCLS { CodigoCliente = oClienteFormCLS.CodigoCliente, NombreCliente = oClienteFormCLS.NombreCliente, Representante = oClienteFormCLS.Representante, Num_Empl = oClienteFormCLS.Num_Empl, LimiteCredito = oClienteFormCLS.LimiteCredito });
        }
    }
}
