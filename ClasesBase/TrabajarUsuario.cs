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
            SqlCommand cmd = new SqlCommand("ListarUsuarios", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("BuscarUsuarioPorCorreo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("SearchUserByUsername", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", nombreUsuario);
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
            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("GetUserRolByCodigo", cnn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
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

            SqlConnection sqlConnection = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("GetUserRolByUsername", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NombreUsuario", username);

            rolDescription = (string)sqlCommand.ExecuteScalar();

            return rolDescription;
        }

        /**
         * Obtiene el listado de roles
         * */
        public static DataTable getListRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("ListarRoles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("InsertarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("ListarUsuariosByRol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("DeleteUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /**
         * Modifica un Usuario
         * */
        public static void editUser(Usuario user, int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
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
