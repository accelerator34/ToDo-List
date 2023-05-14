using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDo_List.Logica;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Concurrent;

namespace ToDo_List.Datos
{
    class DTareas
    {
        //variables
        CONEXION conexion = new CONEXION();
        
        //funciones
        public void Agregar_Tareas(Ltareas Tarea)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Agregar_Tareas", CONEXION.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tarea", Tarea.Tarea);
                cmd.Parameters.AddWithValue("@Fecha_Finalizacion", Tarea.Fecha);
                cmd.Parameters.AddWithValue("@Codigo", Tarea.Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hemos Ingresado la Tarea!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Editar_Tareas(Ltareas Tarea)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Editar_Tareas", CONEXION.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tarea", Tarea.Tarea);
                cmd.Parameters.AddWithValue("@Fecha_Finalizacion", Tarea.Fecha);
                cmd.Parameters.AddWithValue("@Codigo", Tarea.Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hemos Actualizado la Tarea!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Eliminar_Tareas(Ltareas Tarea)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Eliminar_Tareas", CONEXION.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Codigo", Tarea.Codigo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hemos Eliminado la Tarea!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        
        public void Mostrar_Tareas(MenuPrincipal menuPrincipal)
        {
            try
            {
                CONEXION conexion = new CONEXION();
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("Mostrar_Tareas", CONEXION.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader LectorTareas = cmd.ExecuteReader();
                while (LectorTareas.Read())
                {
                    string TareasTraidas = (string)LectorTareas["Tarea"];
                    DateTime Fecha = (DateTime)LectorTareas["Fecha"];
                    string Codigo = (string)LectorTareas["Codigo"];
                    menuPrincipal.nuevoTextBox(TareasTraidas, Codigo, Fecha);
                    //MessageBox.Show(TareasTraidas + " " + Codigo);
                }
                LectorTareas.Close();
                cmd.ExecuteNonQuery();
                //Contarfilas(); // Actualiza el número de filas
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                CONEXION conexion = new CONEXION();
                conexion.Cerrar();
            }
        }
    }
}

