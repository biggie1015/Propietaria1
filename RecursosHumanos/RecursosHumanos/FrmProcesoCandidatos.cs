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

namespace RecursosHumanos
{
    public partial class FrmProcesoCandidatos : Form
    {
        private GEmpleadosLogic GEmpleadosLogic;
        public FrmProcesoCandidatos()
        {
            InitializeComponent();
            GEmpleadosLogic = new GEmpleadosLogic();
        }

        private void FrmProcesoCandidatos_Load(object sender, EventArgs e)
        {
            dgvCandidatos.DataSource = GEmpleadosLogic.GetListadoCandidato();            
            cbxPuesto.DataSource = GEmpleadosLogic.GetPuestos();
            cbxPuesto.DisplayMember = "Codigo";

            cbxIdioma.DataSource = GEmpleadosLogic.GetIdiomas();
            cbxIdioma.DisplayMember = "Codigo";
            



        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dgvCandidatos.SelectedRows.Count > 0)
            {
             
               int candidatoID = Convert.ToInt32(dgvCandidatos.CurrentRow.Cells[0].Value.ToString());
                var frmDetalle = new FrmDetalleCandidatos.FrmDetalleCandidatos(candidatoID);
                frmDetalle.Show();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int candidatoID = Convert.ToInt32(dgvCandidatos.CurrentRow.Cells[0].Value.ToString());
            var result = GEmpleadosLogic.CrearEmpleado(candidatoID);

            if(result > 0)
            {
                MessageBox.Show("Candidato a Empleado exitoso !");
            
            }
            else
            {
                MessageBox.Show("Hubo un error al momento de procesar su solictud.");
            }
            dgvCandidatos.DataSource = GEmpleadosLogic.GetListadoCandidato();
        }
    }
}
