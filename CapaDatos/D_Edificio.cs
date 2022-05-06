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
    public class D_Edificio
    {
        static string conn_string = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

        SqlConnection conexion = new SqlConnection(conn_string);

        //Insertar Edificio
        public void insertEdificio(E_Edificio e_Edificio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", e_Edificio.IdEdificio);
            cmd.Parameters.AddWithValue("@DESCRIPCION", e_Edificio.DescripcionEdificio);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Actualizar edificio
        public void updateEdificio(E_Edificio e_Edificio, int seleccion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITAREDIFICIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SELECCION", seleccion);
            cmd.Parameters.AddWithValue("@NEW_ID", e_Edificio.IdEdificio);
            cmd.Parameters.AddWithValue("@DESCRIPCION", e_Edificio.DescripcionEdificio);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Listar edificio
        public List<E_Edificio> listarEdificios(int buscar)
        {
            conexion.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTAREDIFICIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", buscar);
            reader = cmd.ExecuteReader();
            List<E_Edificio> listar = new List<E_Edificio>();

            while (reader.Read())
            {
                listar.Add(new E_Edificio
                {
                    IdEdificio = reader.GetInt32(0),
                    DescripcionEdificio = reader.GetString(1)

                });

            }
            conexion.Close();
            return listar;
        }
        //Listar edificios general
        public List<E_Edificio> listarEdificiosG()
        {
            conexion.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_LISTAREDIFICIOSG", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            List<E_Edificio> listar = new List<E_Edificio>();

            while (reader.Read())
            {
                listar.Add(new E_Edificio
                {
                    IdEdificio = reader.GetInt32(0),
                    DescripcionEdificio = reader.GetString(1)

                });

            }
            conexion.Close();
            return listar;
        }

    }
}
