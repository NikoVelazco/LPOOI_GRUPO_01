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
    }
}
