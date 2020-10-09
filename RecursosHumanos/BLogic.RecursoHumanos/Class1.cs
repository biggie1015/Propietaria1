using DataAccess.RecursosHumanos;
using DataAccess.RecursosHumanos.BaseRepository;
using System;

namespace BLogic.RecursoHumanos
{
    public class Class1
    {
        Class2 clas = new Class2();
        GestionCompetencias competencias = new GestionCompetencias();
        public void resaltar()
        {
            competencias.GetCompetencias();
        }
    }
}
