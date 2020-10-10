using BusnnessLogic.RecursosHumanos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmPuesto
{
    public partial class FrmPuesto : Form
    {
        private PuestoLogic PuestoLogic;
        private GpuestoLogic GpuestoLogic;
        private bool Editar = false;
        public FrmPuesto()
        {
            InitializeComponent();
            PuestoLogic = new PuestoLogic();
            GpuestoLogic = new GpuestoLogic();
        }

        private void FrmPuesto_Load(object sender, EventArgs e)
        {
            dgvpuesto.DataSource = GpuestoLogic.GetAll();
            dgvpuesto.Columns[3].DefaultCellStyle.Format = "c";
            dgvpuesto.Columns[4].DefaultCellStyle.Format = "c";

            cbxRiesgoSearch.Text = "Selecciona";
            cbxRiesgoSearch.Items.Add("Selecciona");
            cbxRiesgoSearch.Items.Add("Alto");
            cbxRiesgoSearch.Items.Add("medio");
            cbxRiesgoSearch.Items.Add("bajo");

            cbxRiesgo.Text = "Selecciona";
            cbxRiesgo.Items.Add("Selecciona");
            cbxRiesgo.Items.Add("Alto");
            cbxRiesgo.Items.Add("medio");
            cbxRiesgo.Items.Add("bajo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvpuesto.SelectedRows.Count > 0)
            {
                Editar = true;
                txtID.Text = dgvpuesto.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvpuesto.CurrentRow.Cells[1].Value.ToString();
                cbxRiesgo.Text = dgvpuesto.CurrentRow.Cells[2].Value.ToString();
                txtSalarioMin.Text = dgvpuesto.CurrentRow.Cells[3].Value.ToString();
                txtSalarioMin.Text = FormatSalary(txtSalarioMin);
                txtSalarioMax.Text = dgvpuesto.CurrentRow.Cells[4].Value.ToString();
                txtSalarioMax.Text = FormatSalary(txtSalarioMax);
            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvpuesto.SelectedRows.Count > 0)
            {

                txtID.Text = dgvpuesto.CurrentRow.Cells[0].Value.ToString();
                GpuestoLogic.Delete(Convert.ToInt32(txtID.Text));
                dgvpuesto.DataSource = GpuestoLogic.GetAll();
                cleanTxt(this);

            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cleanTxt(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                PuestoLogic.PuestoID = Convert.ToInt32(txtID.Text);
                PuestoLogic.Nombre = txtNombre.Text;
                PuestoLogic.NivelRiesgo = cbxRiesgo.Text;
                PuestoLogic.SalarioMin = double.Parse(txtSalarioMin.Text, NumberStyles.Currency); 
                PuestoLogic.SalarioMax = double.Parse(txtSalarioMax.Text, NumberStyles.Currency);
                GpuestoLogic.Update(PuestoLogic);

            }
            else
            {

              
                PuestoLogic.Nombre = txtNombre.Text;
                PuestoLogic.NivelRiesgo = cbxRiesgo.Text;
                PuestoLogic.SalarioMin = double.Parse(txtSalarioMin.Text, NumberStyles.Currency);
                PuestoLogic.SalarioMax = double.Parse(txtSalarioMax.Text, NumberStyles.Currency);
                GpuestoLogic.Create(PuestoLogic);


            }
            Editar = false;
            cleanTxt(this);
            dgvpuesto.DataSource = GpuestoLogic.GetAll();

        }


        private void cleanTxt(Control control)
        {
            cbxRiesgo.Text = string.Empty;
            txtID.Text = string.Empty;
            cbxRiesgo.Text = "Selecciona";

            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

            }
        }

        private void txtSalarioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtSalarioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txtSalarioMin_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (Double.TryParse(txtSalarioMin.Text, NumberStyles.Currency, null, out amount))
            {
                txtSalarioMin.Text = amount.ToString("C");
            }
        }

        private void txtSalarioMax_Leave(object sender, EventArgs e)
        {
            double amount = 0.0d;
            if (Double.TryParse(txtSalarioMax.Text, NumberStyles.Currency, null, out amount))
            {
                txtSalarioMax.Text = amount.ToString("C");
            }
        }


        private string FormatSalary(Control salary)
        {
            double amount = 0.0d;
            string formated = "";

            if (Double.TryParse(salary.Text, NumberStyles.Currency, null, out amount))
            {
                salary.Text = amount.ToString("C");
            }

            return salary.Text;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           if(cbxRiesgoSearch.Text == "Selecciona") { cbxRiesgoSearch.Text = ""; }
            dgvpuesto.DataSource = GpuestoLogic.Search(txtSearch.Text,cbxRiesgoSearch.Text);
            
        }

        private void cbxRiesgoSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbxRiesgoSearch.Text == "Selecciona") { cbxRiesgoSearch.Text = ""; }
            dgvpuesto.DataSource = GpuestoLogic.Search(txtSearch.Text, cbxRiesgoSearch.Text);
        }
    }
}
