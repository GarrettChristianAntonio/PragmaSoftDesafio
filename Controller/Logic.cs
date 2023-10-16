using Controllers;
using Models.Repositories;
using Models.Entities;
namespace Controller
{
    public class Logic : ILogic
    {

        //inyección
        private readonly IRepository _repository;
        public Logic(IRepository repository) => _repository = repository;



        //metodo conectar
        public (string,bool) Conectar(string paramCadena)
        {
            return _repository.Conectar(paramCadena);
        }

        //metodo getAll
        public List<Serie> ObtenerServicios()
        {            
            return _repository.GetAll();            
        }


        //metodo add
        public bool Agregar(Dictionary<string, object> dic)
        {
            return _repository.Agregar(BuildTopassViewToTheModelAService(dic));
        }


        //metodo put
        public bool Modificar(Dictionary<string, object> dic)
        {
            return _repository.Modificar(BuildTopassViewToTheModelAService(dic));
        }


        //metodo anular
        public bool Anular(string id)
        {
            return _repository.Anular(id);
        }


        //metodo Eliminar
        public bool Eliminar(string id)
        {
            return _repository.Eliminar(id);
        }


        //metodo obtener generos
        public List<String> ObtenerGeneros()
        {           
            return _repository.ObtenerGeneros();           
        }

        //metodo para reutilización de código en el cual se pueden implementar logica de negocio antes de almacenar la información
        //es utilizado tanto por la acción crear y modificar.
        //contiene un condicional para que su implementación sea diferente debido a la falta del parametro id en la acción crear
        public Serie BuildTopassViewToTheModelAService(Dictionary<string, object> dic)
        {
            try
            {
                Serie servicio = new Serie();
                if (dic.ContainsKey("Id"))
                {
                    servicio.Id = Convert.ToInt32(dic["Id"]);
                }
                servicio.Titulo = dic["Titulo"].ToString();
                servicio.Descripcion = dic["Descripcion"].ToString();
                servicio.FechaEstreno = Convert.ToDateTime(dic["FechaEstreno"]);
                servicio.Estrellas = Convert.ToInt32(dic["Estrellas"]);
                servicio.Genero = dic["Genero"].ToString();
                servicio.PrecioAlquiler = Convert.ToDecimal(dic["PrecioAlquiler"]);
                servicio.ATP = Convert.ToBoolean(dic["ATP"]);
                return servicio;
            }
            catch (Exception ex) { throw new Exception(); }
        }
    }
}