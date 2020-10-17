using DataAccess.RecursosHumano;
using System;
using System.Collections.Generic;
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
    }
}
