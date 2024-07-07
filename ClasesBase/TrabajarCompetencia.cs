using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCompetencia
    {
        public static DataTable getCompetencias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "getAllCompetencias";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void saveCompetencia(Competencia competencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarCompetencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", competencia.Com_Nombre);
            cmd.Parameters.AddWithValue("@desc", competencia.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fecI", competencia.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fecF", competencia.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", competencia.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", competencia.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", competencia.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", competencia.Com_Sponsors);
            cmd.Parameters.AddWithValue("@catId", competencia.Cat_ID);
            cmd.Parameters.AddWithValue("@disId", competencia.Dis_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void editCompetencia(Competencia competencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateCompetencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", competencia.Com_ID);
            cmd.Parameters.AddWithValue("@nombre", competencia.Com_Nombre);
            cmd.Parameters.AddWithValue("@desc", competencia.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fecI", competencia.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fecF", competencia.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", competencia.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", competencia.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", competencia.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", competencia.Com_Sponsors);
            cmd.Parameters.AddWithValue("@catId", competencia.Cat_ID);
            cmd.Parameters.AddWithValue("@disId", competencia.Dis_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void deleteCompetencia(int idCompetencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DeleteCompetencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idCompetencia);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
