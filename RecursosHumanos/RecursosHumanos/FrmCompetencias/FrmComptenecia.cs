using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusnnessLogic.RecursosHumanos;

namespace RecursosHumanos.FrmCompetencias
{
    public partial class FrmComptenecia : Form
    {
        private GCompetenciasLogic competencias;
        private  bool Editar = false;
        public FrmComptenecia()
        {
            InitializeComponent();
            competencias = new GCompetenciasLogic();
            
        }

        private void FrmComptenecia_Load(object sender, EventArgs e)
        {
              dgvCompetencias.DataSource = competencias.GetAll();
              dgvCompetencias.ClearSelection();
         
            //lblCompetencias.Left = (lblCompetencias.Parent.Width - lblCompetencias.Width) / 2;
            //lblCompetencias.Top = (lblCompetencias.Parent.Height - lblCompetencias.Height) / 2;

        }

        private void dgvCompetencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvCompetencias.SelectedRows.Count > 0)
            {
                Editar = true;
                txtID.Text = dgvCompetencias.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvCompetencias.CurrentRow.Cells[1].Value.ToString();
         
                
            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                
                competencias.Update(txtDescripcion.Text, Convert.ToInt32(txtID.Text));
                txtID.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
               
               
                competencias.Create(txtDescripcion.Text);
                txtID.Text = "";
                txtDescripcion.Text = "";
                
            }
            Editar = false;
            dgvCompetencias.DataSource = competencias.GetAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompetencias.SelectedRows.Count > 0)
            {
              
                txtID.Text = dgvCompetencias.CurrentRow.Cells[0].Value.ToString();
                competencias.Delete(Convert.ToInt32(txtID.Text));
                dgvCompetencias.DataSource = competencias.GetAll();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }

            txtDescripcion.Text = "";
            txtID.Text = "";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

             dgvCompetencias.DataSource = competencias.getByID(txtSearch.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDescripcion.Text = "";
            Editar = false;

        }

        private void dgvCompetencias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
