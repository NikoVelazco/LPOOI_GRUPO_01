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

        public static Boolean competenciaIsNotAllowed(int com_Id)
        {
            Boolean isFound;
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
            string stateNotAllowed = "cancelado";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = @"
                    SELECT COUNT (Com_Estado)
                    FROM Competencia
                    WHERE Com_ID = @com_Id AND Com_Estado = @stateNotAllowed
                ";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;

                sqlCommand.Parameters.AddWithValue("@com_Id", com_Id);
                sqlCommand.Parameters.AddWithValue("@stateNotAllowed", stateNotAllowed);

                isFound = Convert.ToBoolean((int)sqlCommand.ExecuteScalar());
            }

            return isFound;
        }

        public static DataTable getAllowedCompetencias()
        {
            string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
            string stateNotAllowed = "cancelado";
            string sqlQuery= @"
                SELECT
                    Com_ID AS 'Id',
                    Com_Nombre AS 'Nombre',
                    Com_FechaInicio AS 'Fecha_Inicio',
                    Com_FechaFin AS 'Fecha_Fin'
                FROM Competencia
                WHERE NOT Com_Estado = @stateNotAllowed
            ";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
	            {
                    //sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@stateNotAllowed", stateNotAllowed);
                    sqlConnection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
	            }
            }
        }
    }
}
