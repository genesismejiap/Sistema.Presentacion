using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NCategoriaDocumentacion
    {
        public static DataTable Listar()
        {
            DCategoriaDocumentacion Datos = new DCategoriaDocumentacion();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Id_Documentacion_Beca)
        {
            DCategoriaDocumentacion Datos = new DCategoriaDocumentacion();
            return Datos.Buscar(Id_Documentacion_Beca);
        }

        public static string Insertar(int Id_Beca, string Tipo_Documento, DateTime Fecha_Entrega, string Estado)
        {
            DCategoriaDocumentacion Datos = new DCategoriaDocumentacion();
            string Existe = Datos.Existe(Id_Beca, Tipo_Documento);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaDocumentacion Obj = new CategoriaDocumentacion
                {
                    Id_Beca = Id_Beca,
                    Tipo_Documento = Tipo_Documento,
                    Fecha_Entrega = Fecha_Entrega,
                    Estado = Estado
                };

                return Datos.Insertar(Obj);
            }
        }
        //ERROR


        public static string Actualizar(int Id_Documentacion, int Id_Beca, string Tipo_Documento, DateTime Fecha_Entrega, string Estado)
        {
            DCategoriaDocumentacion Datos = new DCategoriaDocumentacion();
            string Existe = Datos.Existe(Id_Beca, Tipo_Documento);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                CategoriaDocumentacion Obj = new CategoriaDocumentacion
                {
                    Id_Documentacion = Id_Documentacion,
                    Id_Beca = Id_Beca,
                    Tipo_Documento = Tipo_Documento,
                    Fecha_Entrega = Fecha_Entrega,
                    Estado = Estado
                };

                return Datos.Actualizar(Obj);
            }
        }


        public static string Eliminar(int Id_Documentacion_Beca)
        {
            DCategoriaDocumentacion Datos = new DCategoriaDocumentacion();
            return Datos.Eliminar(Id_Documentacion_Beca);
        }

    }
}
