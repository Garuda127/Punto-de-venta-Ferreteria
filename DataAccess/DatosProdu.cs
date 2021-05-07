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
        //Registrar
        public void Reg(string name, string marc,int cat, double pre, string desc, int can)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "insert into productos(ID_Categorias,Nombre,Marca,Precio,Descripcion,InVentario) values (@ID_Categorias,@Nombre,@Marca,@Precio,@Descripcion,@InVentario)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID_Categorias", cat);
            comando.Parameters.AddWithValue("@Nombre", name);
            comando.Parameters.AddWithValue("@Marca", marc);
            comando.Parameters.AddWithValue("@Precio", pre);
            comando.Parameters.AddWithValue("@Descripcion", desc);
            comando.Parameters.AddWithValue("@InVentario", can);
            
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        //Realizar
        public DataTable mostrar()
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("select a.ID_Producto, c.Nombre as Categoria , a.Nombre, a.Marca, a.Precio, a.Descripcion, a.InVentario as Stock from productos a inner join categorias c on c.ID_Categorias = a.ID_Categorias ; " +
                "", getConexion());
            DataTable consul = new DataTable();
            adp.Fill(consul);
            return consul;
        }

        DataTable consulta = new DataTable();
        public DataTable mostrarventas(string name)
        {
            MySqlDataAdapter adp = new MySqlDataAdapter("select Nombre,Precio,InVentario from productos where Nombre = '" + name + "'; " +
                "", getConexion());

            adp.Fill(consulta);
            return consulta;
        }

        //Aplicar filtros a la informacion
        public DataTable busqueda(string nb, string texto)
        { 
            MySqlDataAdapter adp2 = new MySqlDataAdapter("select * from productos where "+ nb +"= '" + texto + "'" + ";", getConexion());
            DataTable consul2 = new DataTable();
            adp2.Fill(consul2);
            return consul2;
        }

        //Se elimina de la base de datos
        public DataTable eliminar(string nb,string texto)
        {
            MySqlDataAdapter adp2 = new MySqlDataAdapter("Delete from productos where " + nb + " = '" + texto + "'" + "; ", getConexion());
            DataTable consul2 = new DataTable();
            adp2.Fill(consul2);
            return consul2;
        }

        //Se realiza la edicion de datos
        public DataTable editar(string Columna, string Modificar, string Producto)
        {
            MySqlDataAdapter adp2 = new MySqlDataAdapter("update productos set "+ Columna + " = "+ Modificar + " where ID_producto = "+ Producto + ";", getConexion());
            DataTable consul2 = new DataTable();
            adp2.Fill(consul2);
            return consul2;
        }
    }
}
