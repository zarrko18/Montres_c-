using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class ParteDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public ParteDAO()
        {
            this.conexion = Conexion.getConexion();
        }
    }
}