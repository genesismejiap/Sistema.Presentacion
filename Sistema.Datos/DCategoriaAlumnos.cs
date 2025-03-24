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
  
    /// CATEGORIA
    public class DCategoriaAlumnos
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoListar", SqlCon);
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

        public DataTable Buscar(string Id_Alumno)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Alumno", SqlDbType.NVarChar).Value = Id_Alumno;
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

        public string Insertar(CategoriaAlumno obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = obj.Apellido;
                Comando.Parameters.Add("@Num_Id", SqlDbType.VarChar).Value = obj.Num_Id;
                Comando.Parameters.Add("@Carrera", SqlDbType.VarChar).Value = obj.Carrera;
                Comando.Parameters.Add("@Estado_Estudio", SqlDbType.VarChar).Value = obj.Estado_Estudio;
                Comando.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = obj.FechaIngreso;
                Comando.Parameters.Add("@FechaFinaliza", SqlDbType.Date).Value = obj.FechaFinaliza;
                Comando.Parameters.Add("@AñosCarrera", SqlDbType.Int).Value = obj.AñosCarrera;
                Comando.Parameters.Add("@Promedio", SqlDbType.Decimal).Value = obj.Promedio;

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

        public string Actualizar(CategoriaAlumno obj)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Alumno", SqlDbType.Int).Value = obj.Id_Alumno;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = obj.Apellido;
                Comando.Parameters.Add("@Num_Id", SqlDbType.VarChar).Value = obj.Num_Id;
                Comando.Parameters.Add("@Carrera", SqlDbType.VarChar).Value = obj.Carrera;
                Comando.Parameters.Add("@Estado_Estudio", SqlDbType.VarChar).Value = obj.Estado_Estudio;
                Comando.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = obj.FechaIngreso;
                Comando.Parameters.Add("@FechaFinaliza", SqlDbType.Date).Value = obj.FechaFinaliza;

                Comando.Parameters.Add("@AñosCarrera", SqlDbType.Int).Value = obj.AñosCarrera;
                Comando.Parameters.Add("@Promedio", SqlDbType.Decimal).Value = obj.Promedio;
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

        public string Eliminar(int Id_Alumno)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoEliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Alumno", SqlDbType.Int).Value = Id_Alumno;
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

        public string Existe(string valor)
        {
            string Resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AlumnoExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = valor;
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

