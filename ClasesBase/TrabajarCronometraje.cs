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
        static readonly string s_connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection s_sqlConnection;
        static SqlCommand s_sqlCommand;
        static SqlDataAdapter s_sqlDataAdapter;

        /* # == Cronometraje (ABM) -------------------------------------- */
        public static void UpdateHoraInicioFinEvento(int eventoId, DateTime horaInicio, DateTime horaFin)
        {
            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("UpdateHoraInicioFinEvento", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@EventoId", eventoId);
                    s_sqlCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                    s_sqlCommand.Parameters.AddWithValue("@HoraFin", horaFin);
                    s_sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateHoraInicioEvento(int eventoId, DateTime horaInicio)
        {
   
            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("UpdateHoraInicioEvento", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@EventoId", eventoId);
                    s_sqlCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                    s_sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
