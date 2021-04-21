using Montres.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class EntradaDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public EntradaDAO()
        {
            this.conexion = Conexion.getConexion();
        }



        public List<Entrada> MostrarEntradas()
        {
            List<Entrada> Entradas = new List<Entrada>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Entrada_Partes";


            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {

                if (list.IsDBNull(5) == true || list.IsDBNull(6) == true)
                {
                    Entradas.Add(new Entrada(
                     list.GetString(0),
                     list.GetString(1),
                     list.GetDateTime(2),
                     list.GetInt32(3),
                     list.GetString(4),
                     "Null",
                     "Null",
                     list.GetDouble(7)
                     ));
                }
                else
                {

                    Entradas.Add(new Entrada(
                        list.GetString(0),
                        list.GetString(1),
                        list.GetDateTime(2),
                        list.GetInt32(3),
                        list.GetString(4),
                        list.GetString(5),
                        list.GetString(6),
                        list.GetDouble(7)
                        ));
                }
            }
            list.Dispose();
            comando.Dispose();
            return Entradas;

        }

    }
}