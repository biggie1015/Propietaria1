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
    public class GCapacitacionLogic
    {
        private CapacitacionRepository capacitacionRepository = null;

        public GCapacitacionLogic()
        {
            capacitacionRepository = new CapacitacionRepository();
        }

        public DataTable GetAll()
        {

            return capacitacionRepository.GetAll();
        }


        public List<Nivel> GetAllNivel()
        {
            var retorno = capacitacionRepository.GetNivel();
            List<Nivel> nivel = new List<Nivel>();
            nivel.Add(new Nivel { NivelID = 0, Nombre = "Selecciona" });

            foreach (var item in retorno)
            {
                nivel.Add(new Nivel { NivelID = item.NivelID, Nombre = item.Nombre });
            }
               
            
            return nivel;
        }


        public int Update(Capacitacion capacitacion)
        {
            DataAccess.RecursosHumano.Models.Capacitacion capacitacion1 = new DataAccess.RecursosHumano.Models.Capacitacion();
            capacitacion1.ID = capacitacion.CapacitacionID;
            capacitacion1.Descrip = capacitacion.Descripcion;
            capacitacion1.NivelID = capacitacion.NivelID;
            capacitacion1.Inst = capacitacion.Institucion;
            capacitacion1.Fecha = capacitacion.Fecha;
            capacitacion1.FechaFinal = capacitacion.FechaFinal;

            return capacitacionRepository.Update(capacitacion1);
        }

        public int Create(Capacitacion capacitacion)
        {
            DataAccess.RecursosHumano.Models.Capacitacion capacitacion1 = new DataAccess.RecursosHumano.Models.Capacitacion();
            capacitacion1.ID = capacitacion.CapacitacionID;
            capacitacion1.Descrip = capacitacion.Descripcion;
            capacitacion1.NivelID = capacitacion.NivelID;
            capacitacion1.Inst = capacitacion.Institucion;
            capacitacion1.Fecha = capacitacion.Fecha;
            capacitacion1.FechaFinal = capacitacion.FechaFinal;

            return capacitacionRepository.Create(capacitacion1);
        }

        //public int Update(string descripcion, int id)
        //{

        //    Idioma idioma = new Idioma();
        //    idioma.IdiomaID = id;
        //    idioma.Nombre = descripcion;
        //    return IdiomaRepository.Update(idioma);
        //}

        public DataTable Search(string Description, int Nivel = 0)
        {

            return capacitacionRepository.Search(Description, Nivel);
        }


        public int Delete(int Id)
        {

            return capacitacionRepository.Delete(Id);
        }
    }


    public class Nivel
    {
        public int NivelID { get; set; }

        public string Nombre { get; set; }
    }

    public class Capacitacion {

        public int CapacitacionID { get; set; }

        public string Descripcion { get; set; }

        public string Nombre { get; set; }

        public int NivelID { get; set; }

        public string Institucion { get; set; }
        public string Fecha { get; set; }

        public string FechaFinal { get; set; }

    }

}
