using Models.Entities;

namespace Models.Repositories
{
    public interface IRepository
    {
        (string,bool) Conectar(string _connectionString);
        List<Serie> GetAll();
        List<String> ObtenerGeneros();
        bool Modificar(Serie servicio);
        bool Agregar(Serie servicio);
        bool Anular(string Id);
        bool Eliminar(string Id);
    }
}
