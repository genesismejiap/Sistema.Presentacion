using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NCategoriaBeca
    {
        public static DataTable Listar()
        {
            DCategoriaBeca Datos = new DCategoriaBeca();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Id_Beca)
        {
            DCategoriaBeca Datos = new DCategoriaBeca();
            return Datos.Buscar(Id_Beca);
        }

        public static string Insertar(int Id_Alumno, int Id_TipoBeca, int Monto_Beca)
        {
            DCategoriaBeca Datos = new DCategoriaBeca();

            string Existe = Datos.Existe(Id_Alumno.ToString());
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaBeca Obj = new CategoriaBeca
                {
                    Id_Alumno = Id_Alumno,
                    Id_TipoBeca = Id_TipoBeca,
                    Monto_Beca = Monto_Beca
                };

                return Datos.Insertar(Obj);
            }
        }




        public static string Actualizar(int Id_Beca, int Id_Alumno, int Id_TipoBeca, int Monto_Beca, string NombreAnt)
        {
            DCategoriaBeca Datos = new DCategoriaBeca();
            string Existe = Datos.Existe(Id_Alumno.ToString());
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaBeca Obj = new CategoriaBeca
                {
                    Id_Beca = Id_Beca,
                    Id_Alumno = Id_Alumno,
                    Id_TipoBeca = Id_TipoBeca,
                    Monto_Beca = Monto_Beca
                };

                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int Id_Alumnos)
        {
            DCategoriaBeca Datos = new DCategoriaBeca();
            return Datos.Eliminar(Id_Alumnos);
        }
    }
}
