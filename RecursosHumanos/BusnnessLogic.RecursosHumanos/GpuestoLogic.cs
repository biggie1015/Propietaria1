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
   public class GpuestoLogic
    {
        private PuestoRepository puestoRepository = null;

        public GpuestoLogic()
        {
            puestoRepository = new PuestoRepository();
        }

        public DataTable GetAll()
        {

            return puestoRepository.GetAll();
        }

        public DataTable Search(string nombre, string nivel)
        {

            return puestoRepository.Search(nombre, nivel);
        }


        public int Update(PuestoLogic puesto)
        {
            DataAccess.RecursosHumano.Models.Puesto puesto1 = new DataAccess.RecursosHumano.Models.Puesto();
            puesto1.PuestoID = puesto.PuestoID;
            puesto1.Nombre = puesto.Nombre;
            puesto1.NivelRiesgo = puesto.NivelRiesgo;
            puesto1.SalarioMin = puesto.SalarioMin;
            puesto1.SalarioMax = puesto.SalarioMax;
            

            return puestoRepository.Update(puesto1);
        }

        public int Create(PuestoLogic puesto)
        {
            DataAccess.RecursosHumano.Models.Puesto puesto1 = new DataAccess.RecursosHumano.Models.Puesto();
            puesto1.PuestoID = puesto.PuestoID;
            puesto1.Nombre = puesto.Nombre;
            puesto1.NivelRiesgo = puesto.NivelRiesgo;
            puesto1.SalarioMin = puesto.SalarioMin;
            puesto1.SalarioMax = puesto.SalarioMax;

            return puestoRepository.Create(puesto1);
        }

      

        //public DataTable Search(string Description, int Nivel = 0)
        //{

        //    return puestoRepository.Search(Description, Nivel);
        //}


        public int Delete(int Id)
        {

            return puestoRepository.Delete(Id);
        }
    }

    public class PuestoLogic 
    {
        public int PuestoID { get; set; }
        public string Nombre { get; set; }
        public string NivelRiesgo { get; set; }
        public double SalarioMin { get; set; }
        public double SalarioMax { get; set; }
    }

}
