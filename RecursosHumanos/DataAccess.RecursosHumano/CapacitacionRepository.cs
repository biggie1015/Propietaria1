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
    public class CapacitacionRepository
    {
        private BaseRepository BaseRepository = null;
        public CapacitacionRepository()
        {
            BaseRepository = new BaseRepository();
        }
        public DataTable GetAll()
        {
            try
            {
                string query = @"select CapacitacionID as ID, Descripcion as Descrip, nc.Nombre, Institucion as Inst, CONVERT(VARCHAR(100),convert(date,Fecha))as Fecha , CONVERT(VARCHAR(100),convert(date,FechaFinal)) as FechaFinal from GCapacitaciones cg
                                    inner join NivelCapacitacion nc
                                    ON cg.Nivel = nc.NivelID
                                    where cg.Activo = 1;";
                var result = BaseRepository.Query<Capacitacion>(query);
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception e)
            {

                throw e;
            }
          

        }


        public List<NivelCapacitacion> GetNivel()
        {
            try
            {
                var result = BaseRepository.Query<NivelCapacitacion>("select NivelID, Nombre from NivelCapacitacion where Activo = 1");
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }


        public int Create(Capacitacion capacitacion)
        {
            try
            {
                string query = @"
                INSERT INTO GCapacitaciones VALUES(@Descrip,@NivelID, @Fecha, @Inst, 1, @FechaFinal)
                ";


                var result = BaseRepository.Query<int>(query, capacitacion).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable Search(string description, int Nivel = 0)
        {
            try
            {
                string query = @"
                select CapacitacionID as ID, Descripcion as Descrip, nc.Nombre, Institucion as Inst, CONVERT(VARCHAR(100),convert(date,Fecha))as Fecha , CONVERT(VARCHAR(100),convert(date,FechaFinal)) as FechaFinal from GCapacitaciones cg
                                    inner join NivelCapacitacion nc
                                    ON cg.Nivel = nc.NivelID WHERE cg.Institucion LIKE  '%'+@Descripcion+'%' and
                                    (@Nivel = 0 OR cg.Nivel = @Nivel) and cg.Activo = 1
                ";


                var result = BaseRepository.Query<Capacitacion>(query, new { Descripcion = description, Nivel = Nivel });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int Update(Capacitacion capacitacion)
        {
            try
            {



                string query = @"
                UPDATE GCapacitaciones
                SET Descripcion = @Descrip,
                Nivel = @NivelID,
	            Fecha = @Fecha,
	            Institucion = @Inst,
	            FechaFinal = @FechaFinal
	            Where CapacitacionID = @ID;
                ";


                var result = BaseRepository.Query<int>(query,capacitacion).FirstOrDefault();
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
                DELETE FROM GCapacitaciones
                WHERE CapacitacionID = @ID
                ";


                var result = BaseRepository.Query<int>(query, new { ID = ID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
