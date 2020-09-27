using DataAccess.RecursosHumano;
using DataAccess.RecursosHumano.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnnessLogic.RecursosHumanos
{
    public class GCompetenciasLogic
    {
        private CompetenciaRepository competencia = null;
        

        public GCompetenciasLogic()
        {
            competencia = new CompetenciaRepository();
        }

         public DataTable GetAll()
        {
            
            return competencia.GetAll();
        }

        public int Create(string descp)
        {

            return competencia.Create(descp);
        }

        public int Update(string descripcion, int id)
        {

            Competencia cpm = new Competencia();
            cpm.CompetenciaID = id;
            cpm.Descripcion = descripcion;
            return competencia.Update(cpm);
        }

        public DataTable getByID(string Description)
        {

            return competencia.GetByID(Description);
        }


        public int Delete(int Id)
        {

            return competencia.Delete(Id);
        }
    }


   
}
