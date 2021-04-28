using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using punto_de_venta;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DatosProdu : Conexion
    {
        public void Reg(string name, string marc, double pre, string desc, int can)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO provee (nombre, tel, mail) VALUES(@nombre, @tel, @mail)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", name);
            comando.Parameters.AddWithValue("@Marca", marc);
            comando.Parameters.AddWithValue("@Precio", pre);
            comando.Parameters.AddWithValue("@Descripcion", desc);
            comando.Parameters.AddWithValue("@InVentario", can);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable mostrar()
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("Select * from productos", getConexion());
            DataTable consul = new DataTable();
            adp.Fill(consul);
            return consul;
        }


        public DataTable busqueda(string texto)
        { 
            MySqlDataAdapter adp2 = new MySqlDataAdapter("select * from provee where nombre = '" + texto + "'" + ";", getConexion());
            DataTable consul2 = new DataTable();
            adp2.Fill(consul2);
            return consul2;
        }


        public void borrar(string bor)
        {
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand("Delete * from provee where nombre= '" + bor + "'" + ";", conexion);
            comando.ExecuteNonQuery();
        }
    }
}
