using MySql.Data.MySqlClient;
using punto_de_venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Common.Cache;
namespace DataAccess
{
    public class UserDao : Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = getConexion())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios where (USER=@user and PASSWORD=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.User = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}