using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    /*--------------*
     | Evento (ABM) |
     *--------------*/
    public class TrabajarEvento
    {
        static readonly string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;
        static Evento oEvento;

        public static DataTable getAllEventos()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("ListarEventos", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        public static void insertEvento(int com_Id, int atl_Id)
        {
            oEvento = new Evento();
            oEvento.Com_ID = com_Id;
            oEvento.Atl_ID = atl_Id;

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("InsertarEvento", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Com_ID", oEvento.Com_ID);
                    sqlCommand.Parameters.AddWithValue("@Atl_ID", oEvento.Atl_ID);
                    sqlCommand.Parameters.AddWithValue("@Estado", "Inscripto");
                    
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
