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
    public class D_Visitantes
    {

        //objeto que me permite abrir la conexion a a sql///
        static string conn_string = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

        SqlConnection conexion = new SqlConnection(conn_string);

        //Insertar Visitante
        public void insertVisitante(E_Visitantes e_Visitantes)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_INSERTARVISITANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", e_Visitantes.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Visitantes.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", e_Visitantes.Carrera);
            cmd.Parameters.AddWithValue("@EDIFICIO", e_Visitantes.Edificio);
            cmd.Parameters.AddWithValue("@HORASALIDA", e_Visitantes.HoraSalida);
            cmd.Parameters.AddWithValue("@MOTIVOVISITA", e_Visitantes.MotivoVisita);
            cmd.Parameters.AddWithValue("@ID_AULA", e_Visitantes.IdAula);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Listar visitantes por nombre
        public List<E_Visitantes> listarVisitasPorNomb(string buscar)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_BUSCARVISITANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            reader = cmd.ExecuteReader();
            List<E_Visitantes> listar =new List<E_Visitantes>();

            while (reader.Read()){
                listar.Add(new E_Visitantes
                {
                    IdVisitante = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Carrera = reader.GetString(3),
                    Edificio = reader.GetInt32(4),
                    HoraEntrada = reader.GetDateTime(5),
                    HoraSalida = reader.GetDateTime(6),
                    MotivoVisita = reader.GetString(7),
                    IdAula = reader.GetString(8)
                });  
            }
            conexion.Close();
            return listar;
        }
        //Listar visitantes por edificio
        public List<E_Visitantes> listarVisitasPorEdif(int buscar)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SP_BUSCARVISPOREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            reader = cmd.ExecuteReader();
            List<E_Visitantes> listar = new List<E_Visitantes>();

            while (reader.Read())
            {
                listar.Add(new E_Visitantes
                {
                    IdVisitante = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Carrera = reader.GetString(3),
                    Edificio = reader.GetInt32(4),
                    HoraEntrada = reader.GetDateTime(5),
                    HoraSalida = reader.GetDateTime(6),
                    MotivoVisita = reader.GetString(7),
                    IdAula = reader.GetString(8)
                });
            }
            conexion.Close();
            return listar;
        }





    }
}
