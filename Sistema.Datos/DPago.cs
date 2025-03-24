using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //agregar
using System.Data.SqlClient; //agregar
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DPago
    {
        //Declaramos el método para listar
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagosListar", SqlCon);
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
        }//Fin public DataTable Listar()

        public DataTable Buscar(string Id_Pago)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagoBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Pago", SqlDbType.VarChar).Value = Id_Pago;
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
        }//Fin public DataTable Buscar(string valor)

        //Declaramos el método para Insertar
        public string Insertar(Pago obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagoInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Alumno", SqlDbType.VarChar).Value = obj.Id_Alumno;
                Comando.Parameters.Add("@FechaPago", SqlDbType.VarChar).Value = obj.FechaPago;
                Comando.Parameters.Add("@Monto", SqlDbType.VarChar).Value = obj.Monto;
                Comando.Parameters.Add("@Mora", SqlDbType.VarChar).Value = obj.Mora;
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
        }//Fin public string Insertar(Categoria obj)

        //Declaramos el método para Actualizar
        public string Actualizar(Pago obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagoActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Pago", SqlDbType.VarChar).Value = obj.Id_Pago;
                Comando.Parameters.Add("@Id_Alumno", SqlDbType.VarChar).Value = obj.Id_Alumno;
                Comando.Parameters.Add("@FechaPago", SqlDbType.VarChar).Value = obj.FechaPago;
                Comando.Parameters.Add("@Monto", SqlDbType.VarChar).Value = obj.Monto;
                Comando.Parameters.Add("@Mora", SqlDbType.VarChar).Value = obj.Mora;
                SqlCon.Open();
                Resp = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede actualizar el registro";
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
        }//Fin public string Actualizar(Categoria obj)

        //Declaramos el método para eliminar
        public string Eliminar(int Id_Pago)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagoEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Pago", SqlDbType.VarChar).Value = Id_Pago;
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
        }// Fin public string Eliminar(int id)

        //Declarar método para comprobar existencia
        public string Existe(string valor)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("PagoExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
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
        }// Fin public string Existe(string valor)
    }//Fin public class DCategoría
}// Fin namespace Sistema.Datos