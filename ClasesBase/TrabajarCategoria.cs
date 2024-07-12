﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    /* # == Categoria (ABM) -------------------------------------- */
    public class TrabajarCategoria
    {
        static readonly string connectionString = ClasesBase.Properties.Settings.Default.comdepConnectionString;
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;
        static Categoria oCategoria;

        /* # == Get a list of Categorias ------------------------- */
        public static DataTable GetAllCategorias()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using(sqlCommand = new SqlCommand("ListarCategorias", sqlConnection))
	            {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;

		            using(sqlDataAdapter = new SqlDataAdapter(sqlCommand))
	                {
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);
                
                        return dataTable;
	                }
	            }
            }
        }

        /* # == Add a Categoria ---------------------------------- */
        public static void AddCategoria(string nombre, string descripcion)
        {
            oCategoria = new Categoria();

            oCategoria.Cat_Nombre = nombre;
            oCategoria.Cat_Descripcion = descripcion;

            using (sqlConnection = new SqlConnection(connectionString))
            {
                using(sqlCommand = new SqlCommand("InsertarCategoria", sqlConnection))
	            {
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Nombre", oCategoria.Cat_Nombre);
                    sqlCommand.Parameters.AddWithValue("@Descripcion", oCategoria.Cat_Descripcion);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        /* # == Update a Categoria ------------------------------- */
        public static void UpdateCategoria(int id, string nombre, string descripcion)
        {
            oCategoria = new Categoria();

            oCategoria.Cat_ID = id;
            oCategoria.Cat_Nombre = nombre;
            oCategoria.Cat_Descripcion = descripcion;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("ActualizarCategoria", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", oCategoria.Cat_ID);
                    sqlCommand.Parameters.AddWithValue("@Nombre", oCategoria.Cat_Nombre);
                    sqlCommand.Parameters.AddWithValue("@Descripcion", oCategoria.Cat_Descripcion);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        /* # == Delete a Categoria ------------------------------- */
        public static void DeleteCategoria(int id)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                using(sqlCommand = new SqlCommand("EliminarCategoria", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
