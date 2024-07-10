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
                    Evento.Eve_ID AS 'Id',
                    Evento.Eve_HoraInicio AS 'Hora Inicio',
                    Evento.Eve_HoraFin AS 'Hora Fin',
                    Evento.Eve_Estado AS 'Estado'
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

        public static void UpdateHoraFinEvent(int eve_Id, DateTime hora_Inicio, DateTime hora_Fin)
        {
            string sqlQuery = @"
                UPDATE Evento
                SET
                    Eve_HoraInicio = @HoraInicio,
                    Eve_HoraFin = @HoraFin
                WHERE
                    Eve_ID = @Eve_Id
            ";
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    //sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Eve_Id", eve_Id);
                    sqlCommand.Parameters.AddWithValue("@HoraInicio", hora_Inicio);
                    sqlCommand.Parameters.AddWithValue("@HoraFin", hora_Fin);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
