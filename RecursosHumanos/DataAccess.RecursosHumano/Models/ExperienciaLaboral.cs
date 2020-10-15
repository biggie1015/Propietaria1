using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano.Models
{
    public class ExperienciaLaboral
    {
        public int ID { get; set; }

        public int CandidatoId { get; set; }

        public string Empresa { get; set; }


        public string Puesto { get; set; }

        public double Salario { get; set; }

        public string FechaDesde { get; set; }


        public string FechaHasta { get; set; }
    }
}
