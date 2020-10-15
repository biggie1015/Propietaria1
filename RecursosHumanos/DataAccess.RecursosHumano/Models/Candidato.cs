using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano.Models
{
    public class Candidato
    {
        public int CandidatoID { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public int PuestoID { get; set; }

        public string Departamento { get; set; }

        public double SalarioAspirar { get; set; }

        public List<int> Competencias { get; set; }

        public List<int> Capacitaciones { get; set; }

        public List<int> Idiomas { get; set; }

        public List<ExperienciaLaboral> ExperienciaLaboral { get; set; }

    }
}
