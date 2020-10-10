using DataAccess.RecursosHumano.Models;
using DataAccess.RecursosHumanos.BaseRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano
{
    public class PuestoRepository
    {
        private BaseRepository BaseRepository = null;

        public PuestoRepository()
        {
            BaseRepository = new BaseRepository();
        }
        public DataTable GetAll()
        {
            var result = BaseRepository.Query<Puesto>(@"select * from GPuestos where Activo = 1");
          
            var retorno = BaseRepository.ToDataTable(result);
            return retorno;

        }


        public int Create(Puesto puesto)
        {
            try
            {
                string query = @"
                INSERT INTO GPuestos VALUES (@Nombre, @NivelRiesgo, @SalarioMin, @SalarioMax,1)
                ";


                var result = BaseRepository.Query<int>(query, puesto).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Search(string nombre, string NivelRiesgo )
        {
            try
            {
                string query = @"
                	        select * from GPuestos where Nombre 
	                            LIKE  '%'+@nombre+'%' and 
	                            NivelRiesgo like '%'+@NivelRiesgo+'%'  and Activo = 1
                ";


                var result = BaseRepository.Query<Puesto>(query, new { nombre = nombre, NivelRiesgo = NivelRiesgo });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int Update(Puesto puesto)
        {
            try
            {



                string query = @"
                Update GPuestos
	            set Nombre = @Nombre,
	            NivelRiesgo = @NivelRiesgo,
	            SalarioMin = @SalarioMin,
	            Salariomax = @SalarioMax
	            where PuestoID = @PuestoID
                ";


                var result = BaseRepository.Query<int>(query, puesto).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Delete(int ID)
        {
            try
            {



                string query = @"
                UPDATE GPuestos
                SET Activo = 0
                WHERE PuestoID = @PuestoID
                ";


                var result = BaseRepository.Query<int>(query, new { PuestoID = ID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
