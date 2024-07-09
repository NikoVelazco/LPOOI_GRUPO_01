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
            string state = "Inscripto";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("InsertarEvento", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Com_ID", oEvento.Com_ID);
                    sqlCommand.Parameters.AddWithValue("@Atl_ID", oEvento.Atl_ID);
                    sqlCommand.Parameters.AddWithValue("@Estado", state);
                    
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void cancelEvento(int eve_Id)
        {
            string sqlQuery = @"
                UPDATE Evento
                SET
                    Eve_Estado = @Estado
                WHERE Eve_ID = @Id;
            ";
            string state = "Anulado";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    //sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", eve_Id);
                    sqlCommand.Parameters.AddWithValue("@Estado", state);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void registerEvento(int eve_Id)
        {
            string sqlQuery = @"
                UPDATE Evento
                SET
                    Eve_Estado = @Estado
                WHERE Eve_ID = @Id
            ";
            string state = "Acreditado";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    //sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", eve_Id);
                    sqlCommand.Parameters.AddWithValue("@Estado", state);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static DataTable searchAtletaByDNI(string atl_Dni)
        {
            string sqlQuery = @"
                SELECT
                    Evento.Eve_ID AS 'Id',
                    Atleta.Atl_Nombre + ', ' + Atleta.Atl_Apellido AS 'Atleta',
                    Competencia.Com_Nombre AS 'Competencia'
                FROM Atleta
                INNER JOIN Evento ON Atleta.Atl_ID = Evento.Atl_ID
                INNER JOIN Competencia ON Evento.Com_ID = Competencia.Com_ID
                WHERE Atleta.Atl_DNI = @Dni AND Evento.Eve_Estado = @Estado
            ";

            string state = "Inscripto";

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@Dni", atl_Dni);
                    sqlCommand.Parameters.AddWithValue("@Estado", state);

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static DataTable getResultadosByComId(int id)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "getResultadosCompetencia";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@id", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = id;

            da.SelectCommand.Parameters.Add(param);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable getTotales(int id) 
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "contarEstadosEventos";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@id", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = id;

            da.SelectCommand.Parameters.Add(param);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
