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
    public class EmpleadoRepository
    {
        private BaseRepository BaseRepository = null;

        public EmpleadoRepository()
        {
            BaseRepository = new BaseRepository();

        }

        public List<ComboBox> GetPuesto()
        {
            try
            {
                var result = BaseRepository.Query<ComboBox>(@"select PuestoID as Id , Nombre as Codigo from GPuestos where Activo = 1 ");
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }


        }



        public List<ComboBox> GetIdiomas()
        {
            try
            {
                var result = BaseRepository.Query<ComboBox>(@"select IdiomaID AS Id, Nombre as Codigo from GIdiomas where Activo= 1 ");
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }


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

        public DataTable GetListadoCandidato()
        {
            try
            {
                var result = BaseRepository.Query<CandidatoProceso>(@"
            select CandidatoID, Cedula, gc.Nombre, Departamento, gp.Nombre as Puesto from GCandidatos gc
            INNER JOIN GPuestos gp
            on gc.PuestoID = gp.PuestoID
            where gc.Activo = 1
            ");
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception e)
            {

                throw e;
            }


        }



        public DataTable GetListadoIdiomas(int candidato)
        {
            try
            {
                var result = BaseRepository.Query<IdiomaCandidato>(@"
                              select Nombre from GIdiomas
                    INNER JOIN IdiomaCandidato 
                    on GIdiomas.IdiomaID = IdiomaCandidato.IdiomaID
                    where IdiomaCandidato.CandidatoID = @CandidatoID
            ", new { CandidatoID = candidato });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception e)
            {

                throw e;
            }


        }


        public DataTable GetListadoCapacitacion(int candidato)
        {
            try
            {
                var result = BaseRepository.Query<CapacitacionCandidato>(@"
                                          select Descripcion as Nombre from GCapacitaciones
            INNER JOIN  RelacionCandidatoCapacitacionID
            ON GCapacitaciones.CapacitacionID = RelacionCandidatoCapacitacionID.CapacitacionID
            WHERE RelacionCandidatoCapacitacionID.CandidatoID = @CandidatoID
            ", new { CandidatoID = candidato });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception e)
            {

                throw e;
            }


        }


        public DataTable GetListadoCompetencia(int candidato)
        {
            try
            {
                var result = BaseRepository.Query<CompetenciaCandidato>(@"
                    select Descripcion as Nombre  from GCompetencias
                    INNER JOIN CompetenciaCandidato
                    ON GCompetencias.CompetenciaID = CompetenciaCandidato.CompetenciaID
                    WHERE CompetenciaCandidato.CandidatoID = @CandidatoID
            ", new { CandidatoID = candidato });
                var retorno = BaseRepository.ToDataTable(result);
                return retorno;
            }
            catch (Exception e)
            {

                throw e;
            }


        }


        public int CrearCandidatoEmpleado(int candidato)
        {
            try
            {
                var result = BaseRepository.Query<int>(@"
                declare @Puesto varchar(max), @Dept varchar(max), @cedula varchar(max);

            select @cedula = Cedula from GCandidatos where CandidatoID= @CandidatoID;

        select @Puesto = gp.Nombre, @Dept = Departamento from GCandidatos gc
                    INNER JOIN GPuestos gp
                    on gc.PuestoID = gp.PuestoID
                    where gc.Activo = 1 

        INSERT INTO GEmpleados (Cedula, Nombre, Fecha_Ingreso, Departamento, Puesto, SalarioMensual, Estado)
        select Cedula, Nombre, GETDATE(),@Dept, @Puesto,  Salario, Activo from GCandidatos where CandidatoID = @CandidatoID
        

            update GCandidatos 
            set Activo = 0
            where CandidatoID = @CandidatoID;

        select count(*) from GEmpleados where Cedula = @cedula

            ", new { CandidatoID = candidato }).FirstOrDefault();
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }


        }

    }

    #region CLASES

    public class PuestoL
    {
        public int PuestoID { get; set; }
    }

    #endregion
}
