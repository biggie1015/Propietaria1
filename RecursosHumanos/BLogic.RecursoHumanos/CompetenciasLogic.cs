using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using DataAccess.RecursosHumanos.BaseRepository;

namespace BLogic.RecursoHumanos
{
    public class CompetenciasLogic
    {
        private GestionCompetencias competencias;
        public CompetenciasLogic()
        {
             competencias = new GestionCompetencias();
        }



        public List<int> Get()
        {
            return competencias.GetCompetencias();
        }

    }
}
