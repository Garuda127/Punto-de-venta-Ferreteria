﻿using System;
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
        string bb;

        public DataTable mostrar()
        {
            ins = "Select * from provee";
            MySqlDataAdapter adp = new MySqlDataAdapter(ins, getConexion());
            DataTable consul = new DataTable();
            adp.Fill(consul);
            return consul;
        }


        public DataTable busqueda(string texto)
        {
            bb = "select * from provee where nombre = '"+  texto +"'"+";";
            MySqlDataAdapter adp2 = new MySqlDataAdapter(bb, getConexion());
            DataTable consul2 = new DataTable();
            adp2.Fill(consul2);
            return consul2;
        }
    }
}
