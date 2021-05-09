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

            public void Reg(int id, string fecha, int total)  //registra venta en la bd
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "insert into venta(ID_Venta,Fecha,Total) values (@ID_Venta,@Fecha,@Total)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@ID_Venta", id);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Total", total);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
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
