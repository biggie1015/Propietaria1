using DataAccess.RecursosHumano.Models;
using DataAccess.RecursosHumanos;
using DataAccess.RecursosHumanos.BaseRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RecursosHumano
{
    public class CandidatosRepository
    {
        private BaseRepository BaseRepository = null;

        public CandidatosRepository()
        {
            BaseRepository = new BaseRepository();

        }
        public List<ComboBox> GetCompetencia()
        {
            var result = BaseRepository.Query<ComboBox>(@"select CompetenciaID as ID, Descripcion AS Codigo  
                                                        from GCompetencias where Activo = 1");
            return result;

        }

        public List<ComboBox> GetCapacitaciones()
        {
            try
            {
                var result = BaseRepository.Query<ComboBox>(@"select CompetenciaID as ID, Descripcion AS Codigo  
                                                        from GCompetencias where Activo = 1");
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
          

        }

        public List<ComboBox> GetNombrePuesto()
        {
            try
            {
                var result = BaseRepository.Query<ComboBox>(@"select  PuestoID as Id,Nombre as Codigo from GPuestos where Activo = 1");
                //var retorno = BaseRepository.ToDataTable(result);

                return result;
            }
            catch (Exception e )
            {

                throw e ;
            }
            

        }


        public List<ComboBox> GetIdiomas()
        {
            try
            {
                var result = BaseRepository.Query<ComboBox>(@"select IdiomaID as  ID, Nombre as Codigo  from GIdiomas where Activo = 1;");
                //var retorno = BaseRepository.ToDataTable(result);

                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
       

        }


        //public DataTable GetCapacitacionCandidato()
        //{
        //    var result = BaseRepository.Query<ComboBox>(@"select  PuestoID as Id,Nombre as Codigo from GPuestos where Activo = 1");
        //    //var retorno = BaseRepository.ToDataTable(result);

        //    return result;

        //}


        public List<decimal> GetNombreSalarioByPuesto(int PuestoID)
        {
            var result = BaseRepository.Query<decimal>(@"select  SalarioMin from GPuestos
                                                        where PuestoID = @PuestoID and Activo = 1
                                                            UNION
                                                            select  Salariomax from GPuestos
                                                            where PuestoID = @PuestoID and Activo = 1", new { PuestoID  = PuestoID });
            //var retorno = BaseRepository.ToDataTable(result);
            return result;

        }


        public int CreateCandidato(Candidato candidato)
        {
           
            try
            {
                string query = @"
                INSERT INTO GCandidatos VALUES(@Cedula, @Nombre, @PuestoID, @Departamento, @SalarioAspirar, '',1);
                 select top 1 CandidatoID  from GCandidatos  order by CandidatoID desc;
                ";


                var result = BaseRepository.Query<int>(query, candidato).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int CreateExperiencia(ExperienciaLaboral experienciaLaboral)
        {

            try
            {
                string query = @"
                INSERT INTO ExperienciaLaboralCandidato VALUES(@Empresa, @Puesto, @Salario, @FechaDesde, @FechaHasta, @CandidatoID);
                 select top 1 CandidatoID  from GCandidatos  order by CandidatoID desc;
                ";


                var result = BaseRepository.Query<int>(query, experienciaLaboral).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int CompetenciaCandidato(int competenciaID, int CandidatoID)
        {

            try
            {
                string query = @"
                INSERT INTO CompetenciaCandidato values(@CompetenciaID, @CandidatoID);
                ";


                var result = BaseRepository.Query<int>(query, new { CompetenciaID = competenciaID, CandidatoID= CandidatoID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int CapacitacionCandidato(int CapacitacionID, int CandidatoID)
        {

            try
            {
                string query = @"
              INSERT INTO RelacionCandidatoCapacitacionID VALUES (@CandidatoID, @CapacitacionID);
                ";


                var result = BaseRepository.Query<int>(query, new { CapacitacionID = CapacitacionID, CandidatoID = CandidatoID }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int ExperienciaLaboralRelacion(int candidato, int exp)
        {

            try
            {
                string query = @"
              INSERT INTO ExperienciaCandidato VALUES (@CandidatoID, @Experiencia);
                ";


                var result = BaseRepository.Query<int>(query, new { Experiencia = exp, CandidatoID = candidato }).FirstOrDefault();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int IdiomaCandidato(int Idioma, int CandidatoID)
        {

            try
            {
                string query = @"
              INSERT INTO IdiomaCandidato values(@IdiomaID, @CandidatoID);
                ";


                var result = BaseRepository.Query<int>(query, new { IdiomaID = Idioma, CandidatoID = CandidatoID }).FirstOrDefault();
                return result;
            }
            catch (Exception e )
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
