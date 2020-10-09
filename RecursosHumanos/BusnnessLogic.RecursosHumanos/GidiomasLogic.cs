using DataAccess.RecursosHumano;
using DataAccess.RecursosHumano.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnnessLogic.RecursosHumanos
{
    public class GidiomasLogic
    {
        private IdiomaRepository IdiomaRepository = null;

        public GidiomasLogic()
        {
            IdiomaRepository = new IdiomaRepository();
        }

        public DataTable GetAll()
        {

            return IdiomaRepository.GetAll();
        }

        public int Create(string nombre)
        {

            return IdiomaRepository.Create(nombre);
        }

        public int Update(string descripcion, int id)
        {

            Idioma idioma = new Idioma();
            idioma.IdiomaID = id;
            idioma.Nombre = descripcion;
            return IdiomaRepository.Update(idioma);
        }

        public DataTable getByID(string Description)
        {

            return IdiomaRepository.GetByID(Description);
        }


        public int Delete(int Id)
        {

            return IdiomaRepository.Delete(Id);
        }
    }
}
