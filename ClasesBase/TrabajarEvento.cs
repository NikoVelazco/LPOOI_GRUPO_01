using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    /* #== Evento (ABM) ==================================================== */
    public class TrabajarEvento
    {
        static readonly string s_connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection s_sqlConnection;
        static SqlCommand s_sqlCommand;
        static SqlDataAdapter s_sqlDataAdapter;

        public static DataTable GetAllEventos()
        {
            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("ListarEventos", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (s_sqlDataAdapter = new SqlDataAdapter(s_sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        s_sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public static void InsertEvento(int com_Id, int atl_Id)
        {
            Evento oEvento = new Evento();
            oEvento.Com_ID = com_Id;
            oEvento.Atl_ID = atl_Id;
            string state = EventoEstado.INSCRIPTO;

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("InsertarEvento", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@Com_ID", oEvento.Com_ID);
                    s_sqlCommand.Parameters.AddWithValue("@Atl_ID", oEvento.Atl_ID);
                    s_sqlCommand.Parameters.AddWithValue("@Estado", state);
                    s_sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateEventoEstado(int eventoId, string eventoEstado)
        {
            string state = EventoEstado.ANULADO;

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("UpdateEventoEstado", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@Id", eventoId);
                    s_sqlCommand.Parameters.AddWithValue("@Estado", eventoEstado);
                    s_sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void RegisterEvento(int eve_Id)
        {
            string state = EventoEstado.ACREDITADO;

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("RegisterEvento", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.Text;
                    s_sqlCommand.Parameters.AddWithValue("@Id", eve_Id);
                    s_sqlCommand.Parameters.AddWithValue("@Estado", state);
                    s_sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static DataTable searchAtletaByDNI(string dni)
        {
            string state = EventoEstado.INSCRIPTO;

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("SearchAtletaByDni", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@Dni", dni);
                    s_sqlCommand.Parameters.AddWithValue("@Estado", state);

                    using (s_sqlDataAdapter = new SqlDataAdapter(s_sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        
                        s_sqlDataAdapter.Fill(dataTable);
                        
                        return dataTable;
                    }
                }
            }
        }

        public static DataTable SearchEventoByAtletaAndCompetencia(int atletaId, int competenciaId)
        {
            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("SearchEventoByAtletaAndCompetencia", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@AtletaId", atletaId);
                    s_sqlCommand.Parameters.AddWithValue("@CompetenciaId", competenciaId);

                    using (s_sqlDataAdapter = new SqlDataAdapter(s_sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        s_sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }
    }
}
