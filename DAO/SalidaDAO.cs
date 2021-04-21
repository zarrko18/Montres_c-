using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class SalidaDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public SalidaDAO()
        {
            this.conexion = Conexion.getConexion();
        }
    }
}