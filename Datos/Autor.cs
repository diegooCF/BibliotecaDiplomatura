using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class Autor
    {
        // metodos
        public static void Agregar(Entidades.Autor pAutor)
        {
            // modo conectado

            // creo un objeto de sqlconnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            // variable string con sentencia a ejecutar
            string strSQL=@"Insert Into Autores(Apellido,Nombre,FechaNacimiento,Nacionalidad) 
                          values (@Apellido,@Nombre,@FechaNacimiento,@Nacionalidad)";
            // creo objeto de clase SQLCOMMAND
            SqlCommand comAgregar = new SqlCommand(strSQL, objConexion);

            // parametros
            comAgregar.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            comAgregar.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            comAgregar.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            comAgregar.Parameters.AddWithValue("@Nacionalidad", pAutor.Nacionalidad);

            try
            {
                objConexion.Open();
                // ejecutar el comando
                comAgregar.ExecuteNonQuery();
                // cierro la conexion
                objConexion.Close();
            } 
            catch (Exception)
            {
                throw new Exception("Error en acceso a datos");
            }
            // abrir la CONEXION a la base de datos
          
        }

        public static void Eliminar(int pCodigo)
        {
            string strProc = "procEliminaAutor"; //nombre procedure
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCommand = new SqlCommand(strProc, objConexion);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@Codigo", pCodigo);

            try
            {
                objConexion.Open();
                objCommand.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Error en transaccion");
            }
            finally
            {
                if (objConexion.State == ConnectionState.Open)
                    objConexion.Close();
            }
        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            // variable sentencia
            string strSQL = @"SELECT  
                              Codigo,
                              Apellido+' '+Nombre as Autor,
                              FechaNacimiento,
                              Nacionalidad  
                              FROM Autores";
            SqlDataAdapter daTraer = new SqlDataAdapter(strSQL, Conexion.strConexion);
            // Poblar el datatable dt
            daTraer.Fill(dt);
            return dt;
        }

        public static void Modificar(Entidades.Autor pAutor)
        {
            string strProc = "procModificaAutor"; //nombre procedure
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCommand = new SqlCommand(strProc, objConexion);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@Codigo", pAutor.Codigo);
            objCommand.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            objCommand.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            objCommand.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            objCommand.Parameters.AddWithValue("@Nacionalidad", pAutor.Nacionalidad);

            try
            {
                objConexion.Open();
                objCommand.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Error en transaccion");
            }
            finally
            {
                if(objConexion.State == ConnectionState.Open)
                    objConexion.Close();
            }
        }

        public static Entidades.Autor TraerAutor(int pCodigo)
        {
            Entidades.Autor objAutor = new Entidades.Autor();
            string strQuery = "SELECT * FROM Autores WHERE Codigo = @Codigo";
            SqlConnection sqlConnection = new SqlConnection(Conexion.strConexion);
            SqlCommand sqlCommand = new SqlCommand(strQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Codigo", pCodigo);
            SqlDataReader sqlDataReader;

            //Data reader, de solo lectura y secuenciales
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    //encontro coincidencia
                    objAutor.Codigo = pCodigo;
                    objAutor.Apellido = sqlDataReader["Apellido"].ToString();
                    objAutor.Nombre = sqlDataReader["Nombre"].ToString();
                    objAutor.FechaNacimiento = Convert.ToDateTime(sqlDataReader["FechaNacimiento"].ToString());
                    objAutor.Nacionalidad = sqlDataReader["Nacionalidad"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return objAutor;
        }      
    }
}
