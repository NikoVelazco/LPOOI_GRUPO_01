using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        /**
         * Valida que el usuario exista en la tabla de usuario
         * para el login
         * */
        public static bool validarUsuario(string nombre, string contrasenia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", cnn);
            SqlDataReader dr;
            cnn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (nombre == dr["Usu_NombreUsuario"].ToString() && contrasenia == dr["Usu_Contraseña"].ToString())
                {
                    dr.Close();
                    cnn.Close();
                    return true;
                }
            }
            dr.Close();
            cnn.Close();
            return false;
        }

        /**
         * Recupera email
         * */
        public static DataTable buscarPorCorreo(string email)
        {
            string sentencia = "SELECT * FROM Usuario WHERE Usu_Email = @email";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /**
         * Obtener objeto usuario
         * por nombre
         * */
        public static Usuario searchUserByNameUser(string nombreUsuario)
        {
            string sentencia = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @nameuser";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@nameuser", nombreUsuario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Usuario usuario = new Usuario(int.Parse(row["Usu_ID"].ToString()), row["Usu_NombreUsuario"].ToString(), row["Usu_Contraseña"].ToString(), row["Usu_ApellidoNombre"].ToString(), int.Parse(row["rol_Codigo"].ToString()));
                /*var img = row["Usu_Imagen"];
                if (img.ToString() == "")
                    usuario.Usu_Imagen = Image.FromFile(Util.CompleteImagePath("default-user.png"));
                else
                    usuario.Usu_Imagen = Util.ByteToImage((byte[])row["Usu_Imagen"]);*/
                return usuario;
            }

            return null;
        }

        /**
         * Obtener Rol de usuario
         * */
        public static int getRolCodigo(string nombreUsuario)
        {
            int codigoRol = -1;
            string consulta = @"
            SELECT r.Rol_Codigo 
            FROM Usuario u
            JOIN Rol r ON u.Rol_Codigo = r.Rol_Codigo
            WHERE u.Usu_NombreUsuario = @NombreUsuario";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cnn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    codigoRol = Convert.ToInt32(result);
                }
            }

            return codigoRol;
        }

        /**
         * Obtener Descripción Rol
         * */
        public static string getUserRol(string username)
        {
            string rolDescription = "";
            string query = @"
            SELECT r.Rol_Descripcion
            FROM Usuario AS u
            JOIN Rol AS r ON u.Rol_Codigo = r.Rol_Codigo
            WHERE u.Usu_NombreUsuario = @NombreUsuario";

            SqlConnection sqlConnection = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NombreUsuario", username);

            rolDescription = (string)sqlCommand.ExecuteScalar();

            return rolDescription;
        }
    }
}
