using DataAccess.RecursosHumanos.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano
{
    public class EmpleadoRepository
    {
        private BaseRepository BaseRepository = null;

        public EmpleadoRepository()
        {
            BaseRepository = new BaseRepository();

        }

        public int InicioSeccion(string nombre)
        {
            try
            {
                var result = BaseRepository.Query<int>(@"select Count(Nombre)  from GEmpleados WHERE Nombre = @Nombre ", new { Nombre = nombre}).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
