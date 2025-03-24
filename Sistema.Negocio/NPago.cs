using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPago
    {
        public static DataTable Listar()
        {
            DPago Datos = new DPago();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Id_Pago)
        {
            DPago Datos = new DPago();
            return Datos.Buscar(Id_Pago);
        }

        public static string Insertar(int Id_Alumno, DateTime FechaPago, decimal Monto, decimal Mora)
        {
            DPago Datos = new DPago();

            string Existe = Datos.Existe(Id_Alumno.ToString());
            if (Existe.Equals("1"))
            {
                return "El pago ya existe";
            }
            else
            {
                Pago Obj = new Pago();
                Obj.Id_Alumno = Id_Alumno;
                Obj.FechaPago = FechaPago;
                Obj.Monto = Monto;
                Obj.Mora = Mora;
                return Datos.Insertar(Obj);
            }
        }//Fin public static string Insertar

        public static string Actualizar(int Id_Pago, int Id_Alumno, DateTime FechaPago, decimal Monto, decimal Mora)
        {
            DPago Datos = new DPago();

            string Existe = Datos.Existe(Id_Alumno.ToString());
            if (Existe.Equals("1"))
            {
                return "El pago ya existe";
            }
            else
            {
                Pago Obj = new Pago();
                Obj.Id_Pago = Id_Pago;
                Obj.Id_Alumno = Id_Alumno;
                Obj.FechaPago = FechaPago;
                Obj.Monto = Monto;
                Obj.Mora = Mora;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int Id_Pago)
        {
            DPago Datos = new DPago();
            return Datos.Eliminar(Id_Pago);
        }//Fin public static DataTable Eliminar(int Id_Pago)
    }//Fin public class NCategoria
}//Fin namespace Sistema.Negocio
