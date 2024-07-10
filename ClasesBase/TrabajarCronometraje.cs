using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarCronometraje
    {
        static readonly string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;

        public static DataTable SearchAtletaByPattern(string pattern)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("BuscarAtletaSegunPatron", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Pattern", "%" + pattern + "%");

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public static DataTable SearchEventoByAtletaAndCompetencia(int atl_Id, int com_Id)
        {
            string sqlQuery = @"
                SELECT
                    Evento.Eve_ID,
                    Evento.Eve_HoraInicio,
                    Evento.Eve_HoraFin,
                    Evento.Eve_Estado
                FROM
                    Atleta
                INNER JOIN Evento ON Atleta.Atl_ID = Evento.Atl_ID
                INNER JOIN Competencia ON Evento.Com_ID = Competencia.Com_ID
                WHERE (Atleta.Atl_ID = @Atl_ID) AND (Competencia.Com_ID = @Com_Id)
            ";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    //sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Atl_ID", atl_Id);
                    sqlCommand.Parameters.AddWithValue("@Com_ID", com_Id);

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public static DataTable UpdateHoraFinEvent(string pattern)
        {
            string sqlQuery = @"
                
            ";
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("BuscarAtletaSegunPatron", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Pattern", "%" + pattern + "%");

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
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
