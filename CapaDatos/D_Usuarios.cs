using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Usuarios
    {
        static string conn_string = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

        SqlConnection conexion = new SqlConnection(conn_string);


        //metodo para insertar usuario
        public void insertUsuario(E_Usuarios e_Usuario)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTARUSUARIO", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", e_Usuario.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Usuario.Apellido);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", e_Usuario.FechaNacimiento);
            cmd.Parameters.AddWithValue("@TIPOUSUARIO", e_Usuario.TipoUsuario);
            cmd.Parameters.AddWithValue("@USERPASSWORD", e_Usuario.Password);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Metodo para actualizar usuario

        public void updateUsuario(E_Usuarios e_Usuario)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CODUSUARIO", e_Usuario.CodUsuario);
            cmd.Parameters.AddWithValue("@NOMBRE", e_Usuario.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Usuario.Apellido);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", e_Usuario.FechaNacimiento);
            cmd.Parameters.AddWithValue("@TIPOUSUARIO", e_Usuario.TipoUsuario);
            cmd.Parameters.AddWithValue("@USERPASSWORD", e_Usuario.Password);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        //Eliminar usuario
        public void deleteUsuario(E_Usuarios e_Usuarios)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CODUSUARIO", e_Usuarios.CodUsuario);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //listar Usuarios por nombre
        public List<E_Usuarios> listarUsPornombre(String buscar)
        {
            conexion.Open();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIOPPORNOMBRE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();
            List<E_Usuarios> listar = new List<E_Usuarios>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Usuarios
                {
                    IdUsuario = leerFilas.GetInt32(0),
                    CodUsuario = leerFilas.GetString(1),
                    Nombre = leerFilas.GetString(2),
                    Apellido = leerFilas.GetString(3),
                    FechaNacimiento = leerFilas.GetDateTime(4),
                    TipoUsuario = leerFilas.GetString(5),
                    Password = leerFilas.GetString(6),

                }); 
            }
            conexion.Close();
            return listar;
        }
        //Listar usuarios por codigo
        public List<E_Usuarios> listarUsPorcodigo(String buscar)
        {
            conexion.Open();
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CODUSUARIO", buscar);
            leerFilas = cmd.ExecuteReader();
            List<E_Usuarios> listar = new List<E_Usuarios>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Usuarios
                {
                    IdUsuario = leerFilas.GetInt32(0),
                    CodUsuario = leerFilas.GetString(1),
                    Nombre = leerFilas.GetString(2),
                    Apellido = leerFilas.GetString(3),
                    FechaNacimiento = leerFilas.GetDateTime(4),
                    TipoUsuario = leerFilas.GetString(5),
                    Password = leerFilas.GetString(6),

                });
            }
            conexion.Close();
            return listar;
        }

        //Autenticar usuario
        public E_Usuarios usuarioLogin(String codigoUsuario, String userPassword)
        {
            
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_LOGIN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CODUSUARIO", codigoUsuario);
            cmd.Parameters.AddWithValue("@USERPASSWORD", userPassword);
            leerFilas = cmd.ExecuteReader();
            E_Usuarios e_Usuarios = new E_Usuarios();
            while (leerFilas.Read())
            {
                e_Usuarios.IdUsuario = leerFilas.GetInt32(0);
                e_Usuarios.CodUsuario =leerFilas.GetString(1);
                e_Usuarios.Nombre = leerFilas.GetString(2);
                e_Usuarios.Apellido = leerFilas.GetString(3);
                e_Usuarios.FechaNacimiento = leerFilas.GetDateTime(4);
                e_Usuarios.TipoUsuario = leerFilas.GetString(5);
                e_Usuarios.Password = leerFilas.GetString(6);
            }
            conexion.Close();
            return e_Usuarios;

        }

    }
}
