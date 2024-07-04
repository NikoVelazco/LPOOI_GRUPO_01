using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

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
                var img = row["Usu_Imagen"];
                if (img.ToString() == "")
                    usuario.Usu_Imagen = null;
                else
                    usuario.Usu_Imagen = UtilImagen.ByteToImage((byte[])row["Usu_Imagen"]);
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

        /**
         * Obtiene el listado de roles
         * */
        public static DataTable getListRoles()
        {
            string consulta = @"SELECT * FROM Rol";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /**
         * Alta de Usuario
         * */
        public static void addUser(Usuario user)
        {
            string sentencia = @"INSERT INTO Usuario(Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo, Usu_Email, Usu_Imagen) VALUES(@nom, @pass, @ape, @rol, @email, @imagen)";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@nom", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@ape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@email", user.Usu_Email);
            cmd.Parameters.AddWithValue("@imagen", UtilImagen.ImageToByte(user.Usu_Imagen));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Obtiene la lista de usuarios
         * */
        public static DataTable listUser()
        {
            string consulta = @"SELECT Rol_Descripcion AS 'Rol', Usu_ApellidoNombre AS 'Apellido y Nombre', Usu_NombreUsuario AS 'Usuario', Usu_Contraseña AS 'Contraseña', Usu_Email AS 'Email', Usu_Imagen AS 'Imagen',
            Usu_ID, U.Rol_Codigo FROM Usuario as U LEFT JOIN Rol as R ON (R.Rol_Codigo=U.Rol_Codigo)";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /**
         * Listar usuario por nombre ascendente
         * */
        public static DataTable buscarUsuariosPorNombre(string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "listaUsuariosPorNombre";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nombre;

            da.SelectCommand.Parameters.Add(param);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /**
         * Listar usuario por nombre descendente
         * */
        public static DataTable buscarUsuariosPorNombreDesc(string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "listarUsuariosPorNombreDesc";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nombre;

            da.SelectCommand.Parameters.Add(param);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /**
         * Elimina usuario
         * */
        public static void deleteUser(int id)
        {
            string sentencia = @"DELETE FROM Usuario WHERE Usu_ID = @id";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Modifica un Usuario
         * */
        public static void editUser(Usuario user, int id)
        {
            string sentencia = @"UPDATE Usuario SET Usu_Contraseña = @pass, Usu_ApellidoNombre = @ape, Usu_NombreUsuario = @nom, Rol_Codigo = @rol, Usu_Email = @email, Usu_Imagen = @imagen WHERE Usu_ID = @id";
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand(sentencia, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@ape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@nom", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@email", user.Usu_Email);
            cmd.Parameters.AddWithValue("@imagen", UtilImagen.ImageToByte(user.Usu_Imagen));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
