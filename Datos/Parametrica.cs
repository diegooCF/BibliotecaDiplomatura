using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Parametrica
    {
        public string Tabla { get; set; }
        public Parametrica(string pTabla)
        {
            Tabla = pTabla;
        }
        public void Agregar(string pDescripcion)
        {
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            string query = "procAlta";
            SqlCommand objCommand = new SqlCommand(query, objConexion);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.AddWithValue("@Tabla", Tabla);
            objCommand.Parameters.AddWithValue("@Descripcion", pDescripcion);

            try
            {
                objConexion.Open();
                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(objConexion.State == ConnectionState.Open)
                    objConexion.Close();
            }
        }
        public DataTable Traer()
        {
            DataTable objTable = new DataTable();
            string query = "procVerTodo";
            SqlDataAdapter objAdapter = new SqlDataAdapter(query, Conexion.strConexion);
            objAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand.Parameters.AddWithValue("@Tabla", Tabla);
            try
            {
                objAdapter.Fill(objTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objTable;
        }
    }
}
