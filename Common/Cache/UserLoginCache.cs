using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int IdUser { get; set; }
        public static string User { get; set; }
        public static string Password { get; set; }

        
    }

    public static class ProductosCache
    {
        public static int Id_productos { get; set; }
        public static int Id_Categorias { get; set; }
        public static string Nombre { get; set; }
        public static string Marca { get; set; }
        public static Double Precio { get; set; }
        public static string Descripcion { get; set; }
        public static int Inventario { get; set; }

    }
}
