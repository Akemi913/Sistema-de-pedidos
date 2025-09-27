using AppEmpleadosC.Entities;
namespace AppEmpleadoC.Client.Services
{
    public class DirectorService
    {
        private List<DirectorCLS> lista;
        public DirectorService()
        {
            lista = new List<DirectorCLS>();
            lista.Add(new DirectorCLS() { idDirector = 1, nombreDirector = "Roberto Fernández" });
            lista.Add(new DirectorCLS() { idDirector = 2, nombreDirector = "Maria Gomez" });
            lista.Add(new DirectorCLS() { idDirector = 3, nombreDirector = "Carlos Sanchez" });
        }
        public List<DirectorCLS> listarDirector()
        {
            return lista;
        }
    }
}
