using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    
    public class CategoriaDocumentacion
    {
        public int Id_Documentacion {  get; set; }

        public int Id_Beca {  get; set; }

        public string Tipo_Documento { get; set; }

        public DateTime Fecha_Entrega { get; set; }

        public string Estado {  get; set; }

        
    }
}
