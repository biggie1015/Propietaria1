using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano.Models
{
    public class CandidatoProceso
    {
        public int CandidatoID { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Departamento { get; set; }

        public string Puesto { get; set; }
    }

    public class IdiomaCandidato
    {
        public string Nombre { get; set; }
    }

    public class CapacitacionCandidato
    {
        public string Nombre { get; set; }
    }


    public class CompetenciaCandidato
    {
        public string Nombre { get; set; }
    }
}
