using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano.Models
{
    public class Capacitacion
    {
        public int ID { get; set; }

        public string Descrip { get; set; }

        public int? NivelID { get; set; }

        public string Nombre { get; set; }

        public string Inst { get; set; }
        public string Fecha { get; set; }

        public string FechaFinal { get; set; }
    }


    public class NivelCapacitacion
    {
        public int NivelID { get; set; }

        public string Nombre { get; set; }

        
    }
}
