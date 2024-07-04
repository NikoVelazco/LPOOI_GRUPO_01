using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDisciplina
    {
        public static DataTable listarDisciplinas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT Dis_ID AS ID, Dis_Nombre AS Nombre, Dis_Descripcion AS Descripcion FROM Disciplina";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;
            cmd.CommandText = "getAllDisciplines";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;


        }

        public static DataTable buscarDisciplina(string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarDisciplinasPorNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", nombre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static void ModificarDisciplina(Disciplina dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", dis.Dis_ID);
            cmd.Parameters.AddWithValue("@nombre", dis.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", dis.Dis_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarDisciplina(int ID)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", ID);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void altaDisciplina(Disciplina dis)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", dis.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", dis.Dis_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
