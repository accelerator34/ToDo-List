using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ToDo_List.Datos
{
    public class CONEXION
    {
        public static string Conexion = @"Data Source=DESKTOP-CEOE10G\SQLEXPRESS; Initial Catalog=To_Do_List; Integrated Security=true";
        public static SqlConnection Conectar = new SqlConnection(Conexion);

        public void Abrir()
        {
            if(Conectar.State == ConnectionState.Closed)
            {
                Conectar.Open();
            }
        }
        public void Cerrar()
        {
            if (Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
        }
    }
}
