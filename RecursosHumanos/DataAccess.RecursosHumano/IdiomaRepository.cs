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
    public class IdiomaRepository
    {
        private BaseRepository BaseRepository = null;

        public IdiomaRepository()
        {
            BaseRepository = new BaseRepository();

        }
        public DataTable GetAll()
        {
            var result = BaseRepository.Query<Idioma>("select * from GIdiomas where Activo = 1");
            var retorno = BaseRepository.ToDataTable(result);
            return retorno;

        }


        public int Create(string nombre)
        {
            try
            {
                string query = @"
                INSERT INTO GIdiomas VALUES (@Nombre,1)
                ";


                var result = BaseRepository.Query<int>(query, new { Nombre = nombre }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetByID(string nombre)
        {
            try
            {
                string query = @"
                SELECT * FROM GIdiomas WHERE Nombre LIKE  '%'+@Nombre+'%' and  Activo = 1
                ";


                var result = BaseRepository.Query<Idioma>(query, new { Nombre = nombre });
                var retorno = BaseRepository.ToDataTable(result);
                var prueba;
                return retorno;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public int Update(Idioma idioma)
        {
            try
            {



                string query = @"
                UPDATE GIdiomas 
                SET Nombre = @Nombre
                WHERE IdiomaID = @ID
                ";


                var result = BaseRepository.Query<int>(query, new { Nombre = idioma.Nombre, ID = idioma.IdiomaID }).FirstOrDefault();
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
                DELETE FROM GIdiomas
                WHERE IdiomaID = @IdiomaID
                ";


                var result = BaseRepository.Query<int>(query, new { IdiomaID = ID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
