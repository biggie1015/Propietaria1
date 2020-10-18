using BusnnessLogic.RecursosHumanos;
using RecursosHumanos.FrmConfirmacionCandidato;
using RecursosHumanos.FrmSelectCapacitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RecursosHumanos.FrmSelectCapacitacion.FrmSelectedCapacitacion;

namespace RecursosHumanos.FrmCandidato
{
    public partial class FrmCandidato : Form
    {
        private GCandidatosLogic GCandidatosLogic = null;
        static FrmExperienciaLaboral frmExp = new FrmExperienciaLaboral();
        public List<int> SeleccionCandidato = new List<int>();
        public static List<int> SelectCompetencia = new List<int>();
        public static List<int> SelectIdiomas = new List<int>();
        protected static List<CheckCapacitacion> checks = new List<CheckCapacitacion>();
        protected static List<ExperienciaLaboraCandidato> ExperienciaLaboral = new List<ExperienciaLaboraCandidato>();

        CandidatosViewModel candidatosViewModel = null;
        public FrmCandidato()
        {
            InitializeComponent();
            GCandidatosLogic = new GCandidatosLogic();
            candidatosViewModel = new CandidatosViewModel(); 
        }


        public FrmCandidato(List<ExperienciaLaboraCandidato> experienciaLaboraCandidatos)
        {
            InitializeComponent();
            ExperienciaLaboral.AddRange(experienciaLaboraCandidatos);
            GCandidatosLogic = new GCandidatosLogic();
            candidatosViewModel = new CandidatosViewModel();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            candidatosViewModel.Departamento = txtDept.Text;
            candidatosViewModel.Cedula = txtCedula.Text;
            candidatosViewModel.Nombre = txtNombre.Text;
            candidatosViewModel.Competencias.AddRange(SelectCompetencia.Distinct().ToList());
            candidatosViewModel.Idiomas.AddRange(SelectIdiomas.Distinct().ToList());
            candidatosViewModel.PuestoID = ((ComboBoxLogic)cbxPuesto.SelectedItem).Id;
            candidatosViewModel.Capacitaciones = checks.Select(x => x.Columna).ToList();
            candidatosViewModel.SalarioAspirar = double.Parse(cbxSueldo.Text, NumberStyles.Currency);
            candidatosViewModel.ExperienciaLaboral.AddRange(ExperienciaLaboral);
            GCandidatosLogic.Create(candidatosViewModel);
            SelectCompetencia.Clear();
            SelectIdiomas.Clear();
            checks.Clear();
            ExperienciaLaboral.Clear();
           
      
        }

  

        private void FrmCandidato_Load(object sender, EventArgs e)
        {
            cbxPuesto.DataSource = GCandidatosLogic.GetPuestoNombre();
            var p = GCandidatosLogic.GetCompetencias();
            cbxPuesto.DisplayMember = "Codigo";
            checkListCompetencias.DataSource = GCandidatosLogic.GetCompetencias();
            checkListCompetencias.DisplayMember = "Codigo";
            checkListCompetencias.ValueMember = "Id";


            checkIdiomas.DataSource = GCandidatosLogic.GeIdiomas();
            checkIdiomas.DisplayMember = "Codigo";
            checkIdiomas.ValueMember = "Id";


        }


        public void SaveFormSelected(List<CheckCapacitacion>  checkCapacitacions)
        {
            checks.Clear();
            checks.AddRange(checkCapacitacions);
        }

        private void cbxPuesto_TextChanged(object sender, EventArgs e)
        {
            var prueba = cbxPuesto.Items;
            if(cbxPuesto.SelectedIndex == 0)
            {
                cbxSueldo.ResetText();
                cbxSueldo.DataSource = null;
            }
            else
            {
                var PuestoID = ((ComboBoxLogic)cbxPuesto.SelectedItem).Id;
                cbxSueldo.DataSource = GCandidatosLogic.GetSalarioByPuesto(PuestoID); 
                cbxSueldo.DisplayMember = "Codigo";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(checks.Count > 0)
            {
                var frmCapacitacion = new FrmSelectedCapacitacion(checks);
                frmCapacitacion.Show();
            }
            else
            {
                var frmCapacitacion = new FrmSelectedCapacitacion();
                frmCapacitacion.Show();
            }
            
        }

        //protected void GetListSeleccion(List<int> seleccion)
        //{
        //    SeleccionCandidato.AddRange(seleccion);
        //}

        private void txtCedula_Leave(object sender, EventArgs e)
        {
           if(txtCedula.Text.Length != 11)
            {
                MessageBox.Show("La cedula esta incorrecta");
            }

        }

        private void checkListCompetencias_Click(object sender, EventArgs e)
        {
            candidatosViewModel.Competencias.Clear();
            foreach (ComboBoxLogic item in checkListCompetencias.SelectedItems)
            {
                SelectCompetencia.Add(item.Id);
            }

        
        }

        private void cbxSueldo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkIdiomas_Click(object sender, EventArgs e)
        {
            candidatosViewModel.Idiomas.Clear();
            foreach (ComboBoxLogic item in checkIdiomas.SelectedItems)
            {
                SelectIdiomas.Add(item.Id);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            frmExp.Show();

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLogin = new FrmLogin.FrmLogin();
            frmLogin.Show();
        }
    }
}
