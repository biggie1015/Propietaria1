using BusnnessLogic.RecursosHumanos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmDetalleCandidatos
{
    public partial class FrmDetalleCandidatos : Form
    {
        int CandidatoID = 0;
        private GEmpleadosLogic GEmpleadosLogic = new GEmpleadosLogic();
        public FrmDetalleCandidatos()
        {
            InitializeComponent();
        }


        public FrmDetalleCandidatos(int Candidato)
        {
            InitializeComponent();
            CandidatoID = Candidato;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetalleCandidatos_Load(object sender, EventArgs e)
        {
            dgvCandidatoIdiomas.DataSource = GEmpleadosLogic.GetListadoIdiomas(CandidatoID);
            dgvCandidatoCapacitaciones.DataSource = GEmpleadosLogic.GetListadoCapacitacion(CandidatoID);
            dgvCandidatoCompetencia.DataSource = GEmpleadosLogic.GetListadoCompetencias(CandidatoID);
        }
    }
}
