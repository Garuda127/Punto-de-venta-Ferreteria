using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_de_venta
{
    class Conexion
    {

        public static MySqlConnection getConexion() //Para realizar la conexion con la base de datos
        {
            string bdservidor = "localhost";
            string bdpuerto = "3307";
            string bdusuario = "root";
            string bdpassword = "toor";
            string bd = "serviciosocial";

            string cadenaConexion = "server=" + bdservidor + "; port=" + bdpuerto + "; user id=" + bdusuario + "; password=" + bdpassword + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }

    }
}
