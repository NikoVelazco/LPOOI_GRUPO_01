﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAtleta
    {
        /**
         * Obtiene la lista de atletas
         * */
        public static DataTable listAtleta()
        {
            string consulta = @"SELECT Atl_DNI AS 'DNI', Atl_Apellido AS 'Apellido', Atl_Nombre AS 'Nombre', Atl_Nacionalidad AS 'Nacionalidad', Atl_Entrenador AS 'Entrenador', Atl_Genero AS 'Genero',
                               Atl_Altura AS 'Altura', Atl_Peso AS 'Peso', Atl_FechaNac AS 'Fecha Nacimiento', Atl_Direccion AS 'Direccion', Atl_Email AS 'Email', Atl_ID FROM Atleta";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
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
            string sentencia = @"INSERT INTO Atleta(Atl_DNI, Atl_Apellido, Atl_Nombre, Atl_Nacionalidad, Atl_Entrenador, Atl_Genero, Atl_Altura, Atl_Peso, Atl_FechaNac, Atl_Direccion, Atl_Email) VALUES(@dni, @apell, @nomb, @nac, @entre, @gene, @altura, @peso, @fechanac, @dire, @email)";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apell", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@nomb", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nac", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entre", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@gene", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fechanac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@dire", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", atleta.Atl_Email);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Busca un atleta por DNI
         * */
        public static int searchAtletaByDNI(string dni)
        {
            string consulta = @"SELECT Atl_ID FROM Atleta WHERE Atl_DNI = @dni";
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

    }
}