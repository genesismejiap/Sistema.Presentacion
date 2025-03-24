using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public class NCategoriaAlumnos
    {


        public static DataTable Listar()
        {
            DCategoriaAlumnos Datos = new DCategoriaAlumnos();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Id_Alumno)
        {
            DCategoriaAlumnos Datos = new DCategoriaAlumnos();
            return Datos.Buscar(Id_Alumno);
        }

        public static string Insertar(string Nombre, string Apellido, string Num_Id, string Carrera, string Estado_Estudio, int AñosCarrera, decimal Promedio, DateTime FechaIngreso, DateTime FechaFinaliza)
        {
            DCategoriaAlumnos Datos = new DCategoriaAlumnos();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaAlumno Obj = new CategoriaAlumno();
                Obj.Nombre = Nombre;
                Obj.Apellido = Apellido;
                Obj.Num_Id = Num_Id;
                Obj.Carrera = Carrera;
                Obj.Estado_Estudio = Estado_Estudio;
                Obj.AñosCarrera = AñosCarrera;
                Obj.Promedio = Promedio;
                Obj.FechaIngreso = FechaIngreso;
                Obj.FechaFinaliza = FechaFinaliza;

                return Datos.Insertar(Obj);
            }
        }



        public static string Actualizar(int Id_Alumno, string NombreAnt, string Nombre, string Apellido, string Num_Id, string Carrera, string Estado_Estudio, int AñosCarrera, decimal Promedio, DateTime FechaIngreso, DateTime FechaFinaliza)
        {
            DCategoriaAlumnos Datos = new DCategoriaAlumnos();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaAlumno Obj = new CategoriaAlumno
                {
                    Id_Alumno = Id_Alumno,
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Num_Id = Num_Id,
                    Carrera = Carrera,
                    Estado_Estudio = Estado_Estudio,
                    AñosCarrera = AñosCarrera,
                    Promedio = Promedio,
                    FechaIngreso = FechaIngreso, 
                    FechaFinaliza = FechaFinaliza 
                };

                return Datos.Actualizar(Obj);
            }
        }


        public static string Eliminar(int Id_Alumnos)
        {
            DCategoriaAlumnos Datos = new DCategoriaAlumnos();
            return Datos.Eliminar(Id_Alumnos);
        }


    }
}

