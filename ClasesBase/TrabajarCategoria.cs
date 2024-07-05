using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarCategoria
    {
    /*-----------------*
     | Categoria (ABM) |
     *-----------------*/
        public class TrabajarCategoria
        {
            readonly string connectionString;

            SqlConnection sqlConnection;
            SqlCommand sqlCommand;
            SqlDataAdapter sqlDataAdapter;
            Categoria oCategoria;

            public TrabajarCategoria()
            {
                connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
            }

            /*----------------------------------*
             | Obtiene el listado de categorias |
             *----------------------------------*/
            public DataTable getListOfCategories()
            {
                DataTable dataTable;

                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "getAllCategories";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;

                    sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);
                }

                return dataTable;
            }

            /*----------------------*
             | Agrega una categoria |
             *----------------------*/
            public void addCategory(string nombre, string descripcion)
            {
                oCategoria = new Categoria();

                oCategoria.Cat_Nombre = nombre;
                oCategoria.Cat_Descripcion = descripcion;

                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "addCategory";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Nombre", oCategoria.Cat_Nombre);
                    sqlCommand.Parameters.AddWithValue("@Descripcion", oCategoria.Cat_Descripcion);

                    sqlCommand.ExecuteNonQuery();
                }
            }

            /*-------------------------*
             | Modificar una categoria |
             *-------------------------*/
            public void updateCategory(int id, string nombre, string descripcion)
            {
                oCategoria = new Categoria();

                oCategoria.Cat_ID = id;
                oCategoria.Cat_Nombre = nombre;
                oCategoria.Cat_Descripcion = descripcion;

                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "updateCategory";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", oCategoria.Cat_ID);
                    sqlCommand.Parameters.AddWithValue("@Nombre", oCategoria.Cat_Nombre);
                    sqlCommand.Parameters.AddWithValue("@Descripcion", oCategoria.Cat_Descripcion);

                    sqlCommand.ExecuteNonQuery();
                }
            }

            /*------------------------*
             | Eliminar una categoria |
             *------------------------*/
            public void deleteCategory(int id)
            {
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "deleteCategory";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", id);

                    sqlCommand.ExecuteNonQuery();
                }
            }

            /*------------------------*
             | Cantidad de categorias | 
             *------------------------*/
            //public int getListOfCategoriesSize()
            //{
            //    Int32 size = 0;

            //    using (sqlConnection = new SqlConnection(connectionString))
            //    {
            //        sqlConnection.Open();
            //        sqlCommand = new SqlCommand();

            //        sqlCommand.CommandText = "cantidadDeCategorias";
            //        sqlCommand.CommandType = CommandType.StoredProcedure;
            //        sqlCommand.Connection = sqlConnection;

            //        SqlParameter sqlParameter = new SqlParameter("@Cantidad", SqlDbType.Int);
            //        sqlParameter.Direction = ParameterDirection.Output;
            //        sqlCommand.Parameters.Add(sqlParameter);

            //        sqlCommand.ExecuteNonQuery();

            //        size = (int)sqlCommand.Parameters["@Cantidad"].Value;
            //    }

            //    return size;
            //}
        }
    }
}
