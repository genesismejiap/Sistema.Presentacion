using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class CategoriaBeca
    {
        public int Id_Beca { get; set; }
        public int Id_Alumno { get; set; }
        public int Id_TipoBeca { get; set; }
        public int Monto_Beca { get; set; }
    }
}

