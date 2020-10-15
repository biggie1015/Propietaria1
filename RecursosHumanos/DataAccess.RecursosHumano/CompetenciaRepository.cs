
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
    public class CompetenciaRepository
    {
        private BaseRepository BaseRepository = null;

        public CompetenciaRepository()
        {
            BaseRepository = new BaseRepository();
        }
        public DataTable GetAll()
        {
            var result = BaseRepository.Query<Competencia>("select * from GCompetencias where Activo = 1");
            var retorno = BaseRepository.ToDataTable(result);
            return retorno;

        }


        public int Create(string descripcion)
        {
            try
            {
                string query = @"
                INSERT INTO GCompetencias VALUES (@Descripcion,1)
                ";


                var result = BaseRepository.Query<int>(query, new { Descripcion = descripcion } ).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetByID(string description)
        {
            try
            {
                string query = @"
                SELECT * FROM GCompetencias WHERE Descripcion LIKE  '%'+@Descripcion+'%' and  Activo = 1
                ";


                var result = BaseRepository.Query<Competencia>(query, new { Descripcion = description });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int Update(Competencia competencia)
        {
            try
            {

      

                string query = @"
                UPDATE GCompetencias 
                SET Descripcion = @Descripcion
                WHERE CompetenciaID = @CompetenciaID
                ";


                var result = BaseRepository.Query<int>(query, new  { Descripcion = competencia.Descripcion, CompetenciaID = competencia.CompetenciaID }).FirstOrDefault();
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
                DELETE FROM GCompetencias
                WHERE CompetenciaID = @CompetenciaID
                ";


                var result = BaseRepository.Query<int>(query, new {CompetenciaID = ID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
