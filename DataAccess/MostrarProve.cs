using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using punto_de_venta;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class MostrarProve: Conexion
    {

        string ins;

        public DataTable mostrar()
        {
            ins = "Select * from provee";
            MySqlDataAdapter adp = new MySqlDataAdapter(ins, getConexion());
            DataTable consul = new DataTable();
            adp.Fill(consul);
            return consul;
        }

    }
}
