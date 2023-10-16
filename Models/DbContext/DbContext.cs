namespace Models.ConfigConexion
{
    public  class DbContext
    {
        private static DbContext _dbContext;
        public string CadenaConexion { get;private set; }
        private DbContext() {
            CadenaConexion = "valor predeterminado";
        }
        public static DbContext ObtenerCadena()
        {
            if (_dbContext == null)
            {
                _dbContext = new DbContext();
            }
            return _dbContext;
        }
        public static void CambiarValor(string paramCadenaConexion)
        {
            ObtenerCadena().CadenaConexion = paramCadenaConexion;
        }
        public static string ObtenerValor()
        {
            return ObtenerCadena().CadenaConexion;
        }
    }
}