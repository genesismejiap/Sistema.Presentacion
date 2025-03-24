using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DCategoriaDocumentacion
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionesBecaListar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }//Fin listar

        public DataTable Buscar(string Id_Documentacion_Beca)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionBecaBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Documentacion_Beca", SqlDbType.NVarChar).Value = Id_Documentacion_Beca;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }//Fin Buscar

        public string Insertar(CategoriaDocumentacion obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionBecaInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Documentacion", SqlDbType.Int).Value = obj.Id_Documentacion;
                Comando.Parameters.Add("@Id_Beca", SqlDbType.Int).Value = obj.Id_Beca;
                Comando.Parameters.Add("@Tipo_Documento", SqlDbType.VarChar).Value = obj.Tipo_Documento;
                Comando.Parameters.Add("@Fecha_Entrega", SqlDbType.Date).Value = obj.Fecha_Entrega;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = obj.Estado;

                SqlCon.Open();
                int filasAfectadas = Comando.ExecuteNonQuery();
                Resp = filasAfectadas > 0 ? "OK" : "No se pudo ingresar el registro";

                if (filasAfectadas == 0)
                {
                    Resp += ". Ninguna fila fue afectada.";
                }
            }
            catch (Exception ex)
            {
                Resp = "Error: " + ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Resp;
        }
        //Fin insertar

        public string Actualizar(CategoriaDocumentacion obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionBecaActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Documentacion", SqlDbType.Int).Value = obj.Id_Documentacion;
                Comando.Parameters.Add("@Id_Beca", SqlDbType.Int).Value = obj.Id_Beca;
                Comando.Parameters.Add("@Tipo_Documento", SqlDbType.VarChar).Value = obj.Tipo_Documento;
                Comando.Parameters.Add("@Fecha_Entrega", SqlDbType.Date).Value = obj.Fecha_Entrega;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = obj.Estado;
                SqlCon.Open();
                Resp = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Resp;
        }//Fin actualizar

        public string Eliminar(int Id_Documentacion_Beca)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionBecaEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Documentacion_Beca", SqlDbType.Int).Value = Id_Documentacion_Beca;
                SqlCon.Open();
                Resp = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Resp;
        }//Fin eliminar

        public string Existe(int Id_Beca, string Tipo_Documento)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DocumentacionBecaExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Beca", SqlDbType.Int).Value = Id_Beca;
                Comando.Parameters.Add("@Tipo_Documento", SqlDbType.VarChar).Value = Tipo_Documento;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@Existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Resp = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Resp;
        }
    }
}
