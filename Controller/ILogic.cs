using Models.Entities;
namespace Controllers
{
    public interface ILogic
    {
        (string,bool) Conectar(string paramCadena);
        List<Serie> ObtenerServicios();
        List<String> ObtenerGeneros();
        bool Agregar(Dictionary<string, object> dic);
        bool Modificar(Dictionary<string, object> dic);
        bool Anular(string id);
        bool Eliminar(string id);
        public Serie BuildTopassViewToTheModelAService(Dictionary<string, object> dic);
    }
}