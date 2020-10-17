using DataAccess.RecursosHumano;
using DataAccess.RecursosHumanos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnnessLogic.RecursosHumanos
{
    public class GEmpleadosLogic
    {
        private EmpleadoRepository EmpleadoRepository;
        public GEmpleadosLogic()
        {
            EmpleadoRepository = new EmpleadoRepository();
        }


        public int InicioSeccion(string nombre)
        {
           return  EmpleadoRepository.InicioSeccion(nombre);
        }


        public List<ComboBoxLogic> GetPuestos()
        {
            var retorno = EmpleadoRepository.GetPuesto();
            List<ComboBoxLogic> nivel = new List<ComboBoxLogic>();
            nivel.Add(new ComboBoxLogic { Id = 0, Codigo = "Selecciona" });

            foreach (var item in retorno)
            {
                nivel.Add(new ComboBoxLogic { Id = item.Id, Codigo = item.Codigo });
            }


            return nivel;
           
        }



        public List<ComboBoxLogic> GetIdiomas()
        {
            var retorno = EmpleadoRepository.GetIdiomas();
            List<ComboBoxLogic> nivel = new List<ComboBoxLogic>();
            nivel.Add(new ComboBoxLogic { Id = 0, Codigo = "Selecciona" });

            foreach (var item in retorno)
            {
                nivel.Add(new ComboBoxLogic { Id = item.Id, Codigo = item.Codigo });
            }


            return nivel;

        }


        public DataTable GetListadoCandidato()
        {
            return EmpleadoRepository.GetListadoCandidato();
        }


        public DataTable GetListadoIdiomas(int candidato)
        {
            return EmpleadoRepository.GetListadoIdiomas(candidato);
        }


        public DataTable GetListadoCapacitacion(int candidato)
        {
            return EmpleadoRepository.GetListadoCapacitacion(candidato);
        }


        public DataTable GetListadoCompetencias(int candidato)
        {
            return EmpleadoRepository.GetListadoCompetencia(candidato);
        }



        public int CrearEmpleado(int candidato)
        {
            return EmpleadoRepository.CrearCandidatoEmpleado(candidato);
        }
    }
}
