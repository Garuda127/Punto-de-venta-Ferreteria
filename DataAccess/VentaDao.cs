using MySql.Data.MySqlClient;
using Common.Cache;
using punto_de_venta;
using System.Data;
using System.Collections;

namespace DataAccess
{
    public class VentaDao
    {
        public class VentaDAO : Conexion
        {


            public ArrayList GetProductos()
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
                        ArrayList myAl = new ArrayList();
                        if (reader.HasRows)
                        {

                            while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Productos
                            {

                                myAl.Add(reader.GetString(2));
                            }
                            return myAl;
                        }
                        else
                        {
                            return myAl;
                        }

                    }
                }
            }
        }
    }

}
