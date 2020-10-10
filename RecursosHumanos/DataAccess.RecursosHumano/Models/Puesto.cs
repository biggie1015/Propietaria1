using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano.Models
{
    public class Puesto
    {
        public int PuestoID { get; set; }
        public string Nombre { get; set; }
        public string NivelRiesgo { get; set; }
        public double SalarioMin { get; set; }
        public double SalarioMax { get; set; }

    }
}
