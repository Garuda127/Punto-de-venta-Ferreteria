using MySql.Data.MySqlClient;
using punto_de_venta;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class AgregarProve : punto_de_venta.Conexion
    {

        public string Registro (string nom,string tel, string corr)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password, nombre,apellido, email) VALUES(@usuario, @password, @nombre, @apellido,@email)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nom);
            comando.Parameters.AddWithValue("@tel", tel);
            comando.Parameters.AddWithValue("@mail", corr);
            conexion.Close();
            return null;
        }
    }
}
