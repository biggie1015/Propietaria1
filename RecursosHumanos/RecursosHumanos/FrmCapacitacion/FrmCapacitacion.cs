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

namespace RecursosHumanos.FrmCapacitacion
{
    public partial class FrmCapacitacion : Form
    {
        private GCapacitacionLogic capacitacionLogic;
        private int Nivel = 0;
        private bool Editar = false;
        public FrmCapacitacion()
        {
            InitializeComponent();
            capacitacionLogic = new GCapacitacionLogic();
        }

        private void FrmCapacitacion_Load(object sender, EventArgs e)
        {
            
            cbxNivelAdd.DataSource = capacitacionLogic.GetAllNivel();
            cbxNivel.DataSource = capacitacionLogic.GetAllNivel();
            cbxNivel.DisplayMember = "Nombre";
            cbxNivelAdd.DisplayMember = "Nombre";
            
            dtpInicial.Format = DateTimePickerFormat.Custom;
            dtpInicial.CustomFormat = "dd-MM-yyyy";
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = "dd-MM-yyyy";
            dgvCapacitacion.DataSource = capacitacionLogic.GetAll();
            dgvCapacitacion.Columns["NivelID"].Visible = false;
         


        }

        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Nivel = ((Nivel)cbxNivel.SelectedItem).NivelID;
            dgvCapacitacion.DataSource = capacitacionLogic.Search(txtSearch.Text, Nivel);
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCapacitacion.SelectedRows.Count > 0)
            {
                Editar = true;
                
                txtID.Text = dgvCapacitacion.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvCapacitacion.CurrentRow.Cells[1].Value.ToString();
                cbxNivelAdd.Text = dgvCapacitacion.CurrentRow.Cells[3].Value.ToString();
                txtInstitucion.Text = dgvCapacitacion.CurrentRow.Cells[4].Value.ToString();
                dtpInicial.Value = Convert.ToDateTime(dgvCapacitacion.CurrentRow.Cells[5].Value.ToString());
                dtpFinal.Value = Convert.ToDateTime(dgvCapacitacion.CurrentRow.Cells[6].Value.ToString());



            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCapacitacion.SelectedRows.Count > 0)
            {

                txtID.Text = dgvCapacitacion.CurrentRow.Cells[0].Value.ToString();
                capacitacionLogic.Delete(Convert.ToInt32(txtID.Text));
                dgvCapacitacion.DataSource = capacitacionLogic.GetAll();
            }
            else
            {
                MessageBox.Show("Debe elegir una fila");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var selectCombo = (Nivel)cbxNivelAdd.SelectedItem;
            if (Editar)
            {
                if(cbxNivelAdd.SelectedIndex == 0)
                {
                     MessageBox.Show("Debe de seleccionar un nivel ");
                }
                else
                {
                    Capacitacion capacitacion = new Capacitacion();
                    capacitacion.CapacitacionID = Convert.ToInt32(txtID.Text);
                    capacitacion.Descripcion = txtDescripcion.Text;
                    capacitacion.Institucion = txtInstitucion.Text;
                    capacitacion.Fecha = dtpInicial.Value.ToString();
                    capacitacion.FechaFinal = dtpFinal.Value.ToString();
                    capacitacion.NivelID = selectCombo.NivelID;
                    capacitacionLogic.Update(capacitacion);
                    txtID.Text = "";
                    txtDescripcion.Text = "";
                }
             
            }
            else
            {
                if(cbxNivelAdd.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe de seleccionar un nivel ");
                }
                else
                {
                    Capacitacion capacitacion = new Capacitacion();
                    capacitacion.Descripcion = txtDescripcion.Text;
                    capacitacion.Institucion = txtInstitucion.Text;
                    capacitacion.Fecha = dtpInicial.Value.ToString();
                    capacitacion.FechaFinal = dtpFinal.Value.ToString();
                    capacitacion.NivelID = selectCombo.NivelID;
                    capacitacionLogic.Create(capacitacion);
                }

             
                //competencias.Create(txtDescripcion.Text);
                //txtID.Text = "";
                //txtDescripcion.Text = "";

            }
            Editar = false;
            cleanTxt(this);
            dgvCapacitacion.DataSource = capacitacionLogic.GetAll();
        }



        private void cleanTxt(Control control)
        {
            cbxNivelAdd.Text = string.Empty;
            dtpInicial.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;

            foreach (var c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCapacitacion.DataSource = capacitacionLogic.Search(txtSearch.Text, Nivel);
        }

        private void cbxNivel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

    }


  
}
