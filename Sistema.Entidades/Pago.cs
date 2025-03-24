using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Pago
    {
        public int Id_Pago { get; set; }
        public int Id_Alumno { get; set; }
        public DateTime FechaPago { get; set; }

        public decimal Monto { get; set; }

        public decimal Mora { get; set; }


    }
}
