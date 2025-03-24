using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class CategoriaAlumno
    {
        public int Id_Alumno { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Num_Id { get; set; }

        public string Carrera { get; set; }

        public string Estado_Estudio { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaFinaliza {  get; set; }


        public int AñosCarrera { get; set; }

        public decimal Promedio { get; set; }
    }

}

