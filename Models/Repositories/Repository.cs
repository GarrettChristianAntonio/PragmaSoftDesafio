using Models.ConfigConexion;
using Models.Entities;
using Models.Exceptions;
using Npgsql;
namespace Models.Repositories
{
    public class Repository : IRepository
    {      
        public (string, bool) Conectar(string _connectionString)
        {
            DbContext.CambiarValor(_connectionString);
            using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
            {
                try
                {
                    connection.Open();
                    return ("Conexión con la base de datos exitosa.", true);
                }
                catch (NpgsqlException ex)
                {
                    return ($"No se pudo conectar a la base de datos: {ex.Message}", false);
                }
            }
        }
        public List<Serie> GetAll()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();

                    string query = "SELECT * FROM Servicio"; // Reemplaza "tabla_series" con el nombre de tu tabla real
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        List<Serie> series = new List<Serie>();

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Serie serie = new Serie
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Titulo = reader["Titulo"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    FechaEstreno = Convert.ToDateTime(reader["FechaEstreno"]),
                                    Estrellas = Convert.ToInt32(reader["Estrellas"]),
                                    Genero = reader["Genero"].ToString(),
                                    PrecioAlquiler = Convert.ToDecimal(reader["PrecioAlquiler"]),
                                    ATP = Convert.ToBoolean(reader["ATP"]),
                                    Estado = reader["Estado"].ToString()
                                };
                                series.Add(serie);
                            }
                        }

                        return series;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new DataAccessException("Error al obtener todas las series desde la base de datos.", ex);
            }
        }

        public bool Agregar(Serie servicio)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();

                    // Consulta SQL de inserción
                    string query = @"
                INSERT INTO Servicio (Titulo, Descripcion, FechaEstreno, Estrellas, Genero, PrecioAlquiler, ATP, Estado)
                VALUES (@Titulo, @Descripcion, @FechaEstreno, @Estrellas, @Genero, @PrecioAlquiler, @ATP, @Estado)
                RETURNING Id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@Titulo", servicio.Titulo);
                        cmd.Parameters.AddWithValue("@Descripcion", servicio.Descripcion);
                        cmd.Parameters.AddWithValue("@FechaEstreno", servicio.FechaEstreno);
                        cmd.Parameters.AddWithValue("@Estrellas", servicio.Estrellas);
                        cmd.Parameters.AddWithValue("@Genero", servicio.Genero);
                        cmd.Parameters.AddWithValue("@PrecioAlquiler", servicio.PrecioAlquiler);
                        cmd.Parameters.AddWithValue("@ATP", servicio.ATP);
                        cmd.Parameters.AddWithValue("@Estado", servicio.Estado);

                        // Ejecutar la consulta y obtener el Id del nuevo registro
                        servicio.Id = (int)cmd.ExecuteScalar();

                        // El Id debe ser mayor que 0 para confirmar la inserción exitosa
                        return servicio.Id > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new DataAccessException("Error al agregar el servicio en la base de datos.", ex);
            }
        }
        public bool Modificar(Serie servicio)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();

                    // Consulta SQL de actualización
                    string query = @"
                    UPDATE Servicio
                    SET
                    Titulo = @Titulo,
                    Descripcion = @Descripcion,
                    FechaEstreno = @FechaEstreno,
                    Estrellas = @Estrellas,
                    Genero = @Genero,
                    PrecioAlquiler = @PrecioAlquiler,
                    ATP = @ATP,
                    Estado = @Estado
                    WHERE Id = @Id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@Id", servicio.Id);
                        cmd.Parameters.AddWithValue("@Titulo", servicio.Titulo);
                        cmd.Parameters.AddWithValue("@Descripcion", servicio.Descripcion);
                        cmd.Parameters.AddWithValue("@FechaEstreno", servicio.FechaEstreno);
                        cmd.Parameters.AddWithValue("@Estrellas", servicio.Estrellas);
                        cmd.Parameters.AddWithValue("@Genero", servicio.Genero);
                        cmd.Parameters.AddWithValue("@PrecioAlquiler", servicio.PrecioAlquiler);
                        cmd.Parameters.AddWithValue("@ATP", servicio.ATP);
                        cmd.Parameters.AddWithValue("@Estado", servicio.Estado);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // El número de filas afectadas debe ser mayor que 0 para confirmar la actualización exitosa
                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new DataAccessException("Error al modificar el servicio en la base de datos.", ex);
            }
        }      
       
        public bool Anular(string Id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();

                    // Consulta SQL de actualización
                    string query = @"
                                UPDATE Servicio
                                SET Estado = 'AN'
                                WHERE Id = @ServicioId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@ServicioId", int.Parse(Id));
                       

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // El número de filas afectadas debe ser mayor que 0 para confirmar la actualización exitosa
                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new DataAccessException("Error al cambiar el estado del servicio en la base de datos.", ex);
            }
        }
        public bool Eliminar(string Id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();

                    // Consulta SQL de actualización
                    string query = @"
                                DELETE FROM Servicio
                                WHERE Id = @ServicioId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        // Parámetros
                        cmd.Parameters.AddWithValue("@ServicioId", int.Parse(Id));


                        int rowsAffected = cmd.ExecuteNonQuery();

                        // El número de filas afectadas debe ser mayor que 0 para confirmar la actualización exitosa
                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new DataAccessException("Error al intentar eliminar la Serie", ex);
            }
        }

        public List<string> ObtenerGeneros()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbContext.ObtenerValor()))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Genero FROM Servicio";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        List<String> list = new List<string>();
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string genero = reader["Genero"].ToString();
                                list.Add(genero);

                                // Agrega un mensaje de depuración para registrar cada género obtenido
                                Console.WriteLine($"Género obtenido: {genero}");
                            }
                        }
                        return list;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                // Agrega un registro de error si ocurre una excepción
                Console.WriteLine($"Error al obtener géneros: {ex}");
                throw new DataAccessException("Error al obtener todas las series desde la base de datos.", ex);
            }
        }
    }
}
