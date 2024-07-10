using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    /* # == Resultado -------------------------------------------- */
    public class TrabajarResultado
    {
        static readonly string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;

        /* # == Get a list of Resultados -------------------------------------------- */
        public static DataTable GetResultados(int com_Id)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("ListarResultados", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", com_Id);

                    using (sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return SortedDataTable(dataTable);
                    }
                }
            }
        }

        /* # == Sort list of Resultados and adds new columns ------------------------ */
        private static DataTable SortedDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add("Prime", typeof(string));
            dataTable.Columns.Add("Posición", typeof(int));

            foreach (DataRow row in dataTable.Rows)
            {
                TimeSpan timeSpan = Convert.ToDateTime(row["Hora_Fin"].ToString()) - Convert.ToDateTime(row["Hora_Inicio"].ToString());

                string primeTime = string.Format(
                    "{0} días, {1} horas, {2} minutos, {3} segundos",
                    timeSpan.Days,
                    timeSpan.Hours,
                    timeSpan.Minutes,
                    timeSpan.Seconds
                );
                row["Prime"] = primeTime;
            }

            DataView dataView = dataTable.DefaultView;
            
            dataView.Sort = "Prime ASC";

            DataTable sortedDataTable = dataView.ToTable();
            
            sortedDataTable.Columns["Posición"].SetOrdinal(0);
            sortedDataTable.Columns["Prime"].SetOrdinal(1);

            int position = 1;

            foreach (DataRow row in sortedDataTable.Rows)
            {
                row["Posición"] = position++;
            }

            return sortedDataTable;
        }

        /* # == Get the amount of Atletas según Competencia ------------------------- */
        public static DataTable GetAtletasByCompetencia(int com_Id)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using (sqlCommand = new SqlCommand("CantidadAtletasSegunEstadoEvento", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", com_Id);

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
