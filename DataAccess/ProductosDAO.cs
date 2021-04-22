
using MySql.Data.MySqlClient;
using punto_de_venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Common.Cache;
namespace DataAccess
{
    class ProductosDAO
    {
        public class ProductosDao : Conexion
        {
            public bool GetProductos()
            {
                using (var connection = getConexion())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM productos";                      
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Productos
                            {
                                ProductosCache.Id_productos = reader.GetInt32(0);
                                ProductosCache.Id_Categorias = reader.GetInt32(1);
                                ProductosCache.Nombre = reader.GetString(2);
                                ProductosCache.Marca = reader.GetString(3);
                                ProductosCache.Nombre = reader.GetString(4);
                                ProductosCache.Precio = reader.GetDouble(5);
                                ProductosCache.Descripcion = reader.GetString(6);
                                ProductosCache.Inventario = reader.GetInt32(7);
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
}
