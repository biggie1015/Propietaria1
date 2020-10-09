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

namespace RecursosHumanos.FrmIdiomas
{
    public partial class FrmIdioma : Form
    {
        private GidiomasLogic gidiomasLogic;
        private bool Editar = false;
        private bool  prueba = false;
        public FrmIdioma()
        {
            InitializeComponent();
            gidiomasLogic = new GidiomasLogic();
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            dgvIdiomas.DataSource = gidiomasLogic.GetAll();
            dgvIdiomas.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {
                Editar = true;
                txtID.Text = dgvIdiomas.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvIdiomas.CurrentRow.Cells[1].Value.ToString();


            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {

                txtID.Text = dgvIdiomas.CurrentRow.Cells[0].Value.ToString();
                gidiomasLogic.Delete(Convert.ToInt32(txtID.Text));
                dgvIdiomas.DataSource = gidiomasLogic.GetAll();
                txtID.Text = string.Empty;
                txtNombre.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvIdiomas.DataSource = gidiomasLogic.getByID(txtSearch.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {

                gidiomasLogic.Update(txtNombre.Text, Convert.ToInt32(txtID.Text));
                txtID.Text = "";
                txtNombre.Text = "";
            }
            else
            {


                gidiomasLogic.Create(txtNombre.Text);
                txtID.Text = "";
                txtNombre.Text = "";

            }
            Editar = false;
            dgvIdiomas.DataSource = gidiomasLogic.GetAll();
        }
    }
}
