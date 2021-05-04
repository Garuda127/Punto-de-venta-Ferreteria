using MySql.Data.MySqlClient;
using System;

namespace punto_de_venta
{
   public abstract class Conexion
    {

        public static MySqlConnection getConexion() //Para realizar la conexion con la base de datos
        {
            string bdservidor = "localhost";
            string bdpuerto = "3306";
            string bdusuario = "root";
            string bdpassword = "root";
            string bd = "ferreteria";

            string cadenaConexion = "server=" + bdservidor + "; port=" + bdpuerto + "; user id=" + bdusuario + "; password=" + bdpassword + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
