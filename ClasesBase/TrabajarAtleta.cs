using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAtleta
    {
        static readonly string s_connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection s_sqlConnection;
        static SqlCommand s_sqlCommand;
        static SqlDataAdapter s_sqlDataAdapter;

        /**
         * Obtiene la lista de atletas
         * */
        public static DataTable getAllAtletas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("ListarAtletas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /**
         * Agregar atleta
         * */
        public static void addAtleta(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("InsertarAtleta", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@Apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@Nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@Nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@Entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@Genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@Altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@Peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@FechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@Direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@Email", atleta.Atl_Email);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Busca un atleta por DNI
         * */
        public static int searchAtletaByDNI(string dni)
        {
            string consulta = @"
                SELECT
                    Atl_ID
                FROM Atleta
                WHERE Atl_DNI = @dni
            ";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            cmd.Parameters.AddWithValue("@dni", dni);
            cnn.Open();
            object result = cmd.ExecuteScalar();
            cnn.Close();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return -1;
            }
        }

        /**
         * Edita un atleta
         * */
        public static void editAtleta(Atleta atleta, int idAtleta)
        {
            string sentencia = @"UPDATE Atleta SET Atl_DNi = @dni, Atl_Apellido = @apellido, Atl_Nombre = @nombre, Atl_Nacionalidad = @nacionalidad, Atl_Entrenador = @entrenador, Atl_Genero = @genero, Atl_Altura = @altura, Atl_Peso = @peso, Atl_FechaNac = @fechaNac, Atl_Direccion = @direccion, Atl_Email = @email WHERE Atl_ID = @id";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@id", idAtleta);
            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", atleta.Atl_Email);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Busca atleta por nombre
         * */
        public static DataTable searchAtletaByName(string pattern)
        {
            string consulta = @"SELECT Atl_DNI AS 'DNI', Atl_Apellido AS 'Apellido', Atl_Nombre AS 'Nombre', Atl_Nacionalidad AS 'Nacionalidad', Atl_Entrenador AS 'Entrenador', Atl_Genero AS 'Genero', Atl_Altura AS 'Altura', Atl_Peso AS 'Peso', Atl_FechaNac AS 'Fecha Nacimiento', Atl_Direccion AS 'Direccion', Atl_Email AS 'Email', Atl_ID FROM Atleta WHERE Atl_Nombre LIKE @pattern";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            cmd.Parameters.AddWithValue("@pattern", "%" + pattern + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void deleteAtleta(int id)
        {
            string sentencia = @"DELETE FROM Atleta WHERE Atl_ID = @id";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Obtiene la lista de atletas ordenados por el criterio especificado
         * */
        public static DataTable listarAtletas(string orden, string pattern = "")
        {
            using (SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("listaAtletasOrdenados", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orden", orden);
                    cmd.Parameters.AddWithValue("@pattern", pattern);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static Boolean atletaIsFound(int atl_Id)
        {
            Boolean isFound;

            string sqlQuery = @"
                SELECT COUNT (a.Atl_ID)
                FROM Evento AS e
                JOIN Atleta a ON e.Atl_ID = a.Atl_ID
                WHERE e.Atl_ID = (@Atl_Id)
            ";

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand(sqlQuery, s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.Text;
                    s_sqlCommand.Connection = s_sqlConnection;
                    s_sqlCommand.Parameters.AddWithValue("@Atl_Id", atl_Id);

                    isFound = Convert.ToBoolean((int)s_sqlCommand.ExecuteScalar());
                }
            }

            return isFound;
        }

        public static DataTable getAtletasAcreditados(string state)
        {
            string sqlQuery = @"
                SELECT
                    Atleta.Atl_ID AS 'Id',
                    Atleta.Atl_Nombre + ', ' + Atleta.Atl_Apellido AS 'Atleta'
                FROM
                    Atleta
                INNER JOIN
                    Evento ON Atleta.Atl_ID = Evento.Atl_ID
                WHERE Eve_Estado = @Estado;
            ";

            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand(sqlQuery, s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.Text;
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

        public static DataTable SearchAtletaByPattern(string pattern)
        {
            using (s_sqlConnection = new SqlConnection(s_connectionString))
            {
                using (s_sqlCommand = new SqlCommand("BuscarAtletaSegunPatron", s_sqlConnection))
                {
                    s_sqlConnection.Open();
                    s_sqlCommand.CommandType = CommandType.StoredProcedure;
                    s_sqlCommand.Parameters.AddWithValue("@Pattern", "%" + pattern + "%");

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
