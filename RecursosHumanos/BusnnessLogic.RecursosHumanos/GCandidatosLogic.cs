using DataAccess.RecursosHumano;
using DataAccess.RecursosHumano.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BusnnessLogic.RecursosHumanos
{
    public class GCandidatosLogic
    {
        private CandidatosRepository CandidatosRepository = null;
        Candidato candidatoRepo = null;
        public GCandidatosLogic()
        {
            CandidatosRepository = new CandidatosRepository();
             candidatoRepo = new Candidato();
        }

        public List<ComboBoxLogic> GetCompetencias()
        {
            var competencias =  CandidatosRepository.GetCompetencia();
            List<ComboBoxLogic> combos = new List<ComboBoxLogic>();
            foreach (var item in competencias)
            {
                combos.Add(new ComboBoxLogic { Id = item.Id, Codigo = item.Codigo});
            }

            return combos.ToList() ;
        }



        public int  Create(CandidatosViewModel candidatosViewModel)
        {
            List<ExperienciaLaboral> laboral = new List<ExperienciaLaboral>();
            List<int> Competencias = new List<int>();
            List<int> Capacitacion = new List<int>();
            List<int> idiomas = new List<int>();
            candidatoRepo.Nombre = candidatosViewModel.Nombre;
            candidatoRepo.Departamento = candidatosViewModel.Departamento;
            candidatoRepo.Cedula = candidatosViewModel.Cedula;
            candidatoRepo.SalarioAspirar = candidatosViewModel.SalarioAspirar;
            candidatoRepo.PuestoID = candidatosViewModel.PuestoID;
            candidatoRepo.Competencias = candidatosViewModel.Competencias;
            candidatoRepo.Capacitaciones = candidatosViewModel.Capacitaciones;
            candidatoRepo.Idiomas = candidatosViewModel.Idiomas;
            var IdCandidato = CandidatosRepository.CreateCandidato(candidatoRepo);

            foreach (var item in candidatosViewModel.ExperienciaLaboral)
            {

                laboral.Add(new ExperienciaLaboral
                {
                    CandidatoId = IdCandidato,
                    Empresa = item.Empresa,
                    Puesto = item.Puesto,
                    Salario = item.Salario,
                    FechaDesde = item.FechaDesde,
                    FechaHasta = item.FechaHasta
                    
                }) ;
            }



            foreach (var item in laboral)
            {
                CandidatosRepository.CreateExperiencia(item);
            }

            foreach (var item in candidatoRepo.Competencias)
            {
                CandidatosRepository.CompetenciaCandidato(item, IdCandidato);
            }

            
            foreach (var item in candidatoRepo.Capacitaciones)
            {
                CandidatosRepository.CapacitacionCandidato(item, IdCandidato);
            }


            foreach (var item in candidatoRepo.Idiomas)
            {
                CandidatosRepository.IdiomaCandidato(item, IdCandidato);
            }

            laboral.Clear();
            return 1;

        }


        public List<ComboBoxLogic> GetPuestoNombre()
        {
            var retorno = CandidatosRepository.GetNombrePuesto();
            List<ComboBoxLogic> comboBoxLogics = new List<ComboBoxLogic>();
            comboBoxLogics.Add(new ComboBoxLogic { Id = 0, Codigo = "Selecciona" });

            foreach (var item in retorno)
            {
                comboBoxLogics.Add(new ComboBoxLogic { Id = item.Id, Codigo = item.Codigo });
            }
            return comboBoxLogics;


        }


        public List<string> GetSalarioByPuesto(int ID)
        {
            var ToFormat = CandidatosRepository.GetNombreSalarioByPuesto(ID);
            List<string> formated = new List<string>();
            foreach (var item in ToFormat)
            {
                var Currency = String.Format("{0:C}", item);
                formated.Add(Currency);
            }
            return formated;

        }


        public List<ComboBoxLogic> GeIdiomas()
        {
            var idioma = CandidatosRepository.GetIdiomas();
            List<ComboBoxLogic> idiomas = new List<ComboBoxLogic>();
            foreach (var item in idioma) 
            { 
                idiomas.Add(new ComboBoxLogic { Id = item.Id, Codigo = item.Codigo });
            }

            return idiomas;
        }



    }

 
    public class CandidatosViewModel
    {
        public CandidatosViewModel()
        {
            this.Competencias = new List<int>();
            this.Capacitaciones = new List<int>();
            this.Idiomas = new List<int>();
            this.ExperienciaLaboral = new List<ExperienciaLaboraCandidato>();
        }
        public int CandidatoID { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public int PuestoID { get; set; }

        public string Departamento { get; set; }

        public double SalarioAspirar { get; set; }

        public List<int> Competencias { get; set; }

        public List<int> Capacitaciones { get; set; }

        public List<int> Idiomas { get; set; }

        public List<ExperienciaLaboraCandidato> ExperienciaLaboral { get; set; }

    }


    public class ExperienciaLaboraCandidato
    {
        public int ExperienciaID { get; set; }

        public int CandidatoID { get; set; }

        public string Empresa { get; set; }

        public string Puesto { get; set; }

        public double Salario { get; set; }

        public string FechaDesde { get; set; }

        public string FechaHasta { get; set; }
    }
}
