using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class Numero_AlternoDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public Numero_AlternoDAO()
        {
            this.conexion = Conexion.getConexion();
        }
    }
}