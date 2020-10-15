using BusnnessLogic.RecursosHumanos;
using RecursosHumanos.FrmCandidato;
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

namespace RecursosHumanos.FrmConfirmacionCandidato
{
    public partial class FrmExperienciaLaboral : Form
    {
        public static List<ExperienciaLaboraCandidato> experienciaLaboraCandidatos = new List<ExperienciaLaboraCandidato>();
        private static int CantidadInput = 0;
       public static FrmCandidato.FrmCandidato FrmCandidato = new  FrmCandidato.FrmCandidato();

        TextBox txtEmpresa1 = null;
        TextBox txtEmpresa2 = null;
        TextBox txtEmpresa3 = null;

        TextBox txtPuesto = null;
        TextBox txtPuesto2 = null;
        TextBox txtPuesto3 = null;

        TextBox txtSalario = null;
        TextBox txtSalario2 = null;
        TextBox txtSalario3 = null;

        DateTimePicker dateTimePicker = null;
        DateTimePicker dateTimePicker2 = null;
        DateTimePicker dateTimePicker3 = null;


        DateTimePicker dateTimePickerRight = null;
        DateTimePicker dateTimePickerRight2 = null;
        DateTimePicker dateTimePickerRight3 = null;
        public FrmExperienciaLaboral()
        {
            InitializeComponent();
        }

        private void FrmExperienciaLaboral_Load(object sender, EventArgs e)
        {
            //106, 81
        }


        private void Crearinputs()
        {
            CantidadInput = Convert.ToInt32(txtCantidad.Text);
            int y = 0;
            int Labely = 0;
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();

         

            int Cantidad = Convert.ToInt32(txtCantidad.Text);

                for (int i = 1; i <= Cantidad; i++)
                {

                switch (i)
                {
                    case 1:
                        Label lblEmpresa1 = new Label();
                        lblEmpresa1.Size = new System.Drawing.Size(130, 20);
                        lblEmpresa1.Text = "Empresa";
                        lblEmpresa1.Location = new Point(155,  20);
                        lblEmpresa1.Visible = true;

                         txtEmpresa1 = new TextBox();
                        txtEmpresa1.Size = new System.Drawing.Size(130, 20);
                        txtEmpresa1.Location = new Point(108, 49);
                        txtEmpresa1.Visible = true;

                        Label lbPuesto = new Label();
                        lbPuesto.Size = new System.Drawing.Size(130, 20);
                        lbPuesto.Text = "Puesto Ocupado";
                        lbPuesto.Location = new Point(130, 70);
                        lbPuesto.Visible = true;

                         txtPuesto = new TextBox();
                        txtPuesto.Size = new System.Drawing.Size(130, 20);
                        txtPuesto.Location = new Point(108, 92);
                        txtPuesto.Visible = true;


                        Label lblSalario = new Label();
                        lblSalario.Size = new System.Drawing.Size(130, 20);
                        lblSalario.Text = "Salario";
                        lblSalario.Location = new Point(155, 120);
                        lblSalario.Visible = true;

                         txtSalario = new TextBox();
                        txtSalario.Size = new System.Drawing.Size(130, 20);
                        txtSalario.Location = new Point(108, 141);
                        txtSalario.Visible = true;


                        Label lblFechaDesde = new Label();
                        lblFechaDesde.Size = new System.Drawing.Size(130, 20);
                        lblFechaDesde.Text = "Fecha Desde";
                        lblFechaDesde.Location = new Point(53, 170);
                        lblFechaDesde.Visible = true;

                         dateTimePicker = new DateTimePicker();
                        dateTimePicker.Size = new System.Drawing.Size(100, 20);
                        dateTimePicker.Location = new Point(14, 196);
                        dateTimePicker.Format = DateTimePickerFormat.Custom;
                        dateTimePicker.Visible = true;


                        Label lblFechaHasta = new Label();
                        lblFechaHasta.Size = new System.Drawing.Size(130, 20);
                        lblFechaHasta.Text = "Fecha hasta";
                        lblFechaHasta.Location = new Point(188, 170);
                        lblFechaHasta.Visible = true;

                         dateTimePickerRight = new DateTimePicker();
                        dateTimePickerRight.Size = new System.Drawing.Size(100, 20);
                        dateTimePickerRight.Location = new Point(172, 196);
                        dateTimePickerRight.Format = DateTimePickerFormat.Custom;
                        dateTimePickerRight.Visible = true;


                        panel1.Controls.Add(txtEmpresa1);
                        panel1.Controls.Add(lblEmpresa1);

                        panel1.Controls.Add(lbPuesto);
                        panel1.Controls.Add(txtPuesto);

                        panel1.Controls.Add(lblSalario);
                        panel1.Controls.Add(txtSalario);

                        panel1.Controls.Add(lblFechaDesde);
                        panel1.Controls.Add(dateTimePicker);

                        panel1.Controls.Add(lblFechaHasta);
                        panel1.Controls.Add(dateTimePickerRight);

                        break;

                    case 2:

                        Label lblEmpresa2 = new Label();
                        lblEmpresa2.Size = new System.Drawing.Size(130, 20);
                        lblEmpresa2.Text = "Empresa";
                        lblEmpresa2.Location = new Point(89, Labely + 20);
                        lblEmpresa2.Visible = true;

                         txtEmpresa2 = new TextBox();
                        txtEmpresa2.Size = new System.Drawing.Size(130, 20);
                        txtEmpresa2.Location = new Point(89, y + 49);
                        txtEmpresa2.Visible = true;

                        Label lbPuesto2 = new Label();
                        lbPuesto2.Size = new System.Drawing.Size(130, 20);
                        lbPuesto2.Text = "Puesto Ocupado";
                        lbPuesto2.Location = new Point(89, 70);
                        lbPuesto2.Visible = true;

                         txtPuesto2 = new TextBox();
                        txtPuesto2.Size = new System.Drawing.Size(130, 20);
                        txtPuesto2.Location = new Point(89, 92);
                        txtPuesto2.Visible = true;


                        Label lblSalario2 = new Label();
                        lblSalario2.Size = new System.Drawing.Size(130, 20);
                        lblSalario2.Text = "Salario";
                        lblSalario2.Location = new Point(89, 120);
                        lblSalario2.Visible = true;

                         txtSalario2 = new TextBox();
                        txtSalario2.Size = new System.Drawing.Size(130, 20);
                        txtSalario2.Location = new Point(89, 141);
                        txtSalario2.Visible = true;


                        Label lblFechaDesde2 = new Label();
                        lblFechaDesde2.Size = new System.Drawing.Size(130, 20);
                        lblFechaDesde2.Text = "Fecha Desde";
                        lblFechaDesde2.Location = new Point(33, 170);
                        lblFechaDesde2.Visible = true;

                         dateTimePicker2 = new DateTimePicker();
                        dateTimePicker2.Size = new System.Drawing.Size(100, 20);
                        dateTimePicker2.Location = new Point(18, 196);
                        dateTimePicker2.Format = DateTimePickerFormat.Custom;
                        dateTimePicker2.Visible = true;


                        Label lblFechaHasta2 = new Label();
                        lblFechaHasta2.Size = new System.Drawing.Size(130, 20);
                        lblFechaHasta2.Text = "Fecha hasta";
                        lblFechaHasta2.Location = new Point(211, 170);
                        lblFechaHasta2.Visible = true;

                         dateTimePickerRight2 = new DateTimePicker();
                        dateTimePickerRight2.Size = new System.Drawing.Size(100, 20);
                        dateTimePickerRight2.Location = new Point(190, 196);
                        dateTimePickerRight2.Format = DateTimePickerFormat.Custom;
                        dateTimePickerRight2.Visible = true;



                        panel2.Controls.Add(lblEmpresa2);
                        panel2.Controls.Add(txtEmpresa2);

                        panel2.Controls.Add(lbPuesto2);
                        panel2.Controls.Add(txtPuesto2);


                        panel2.Controls.Add(lblSalario2);
                        panel2.Controls.Add(txtSalario2);



                        panel2.Controls.Add(lblFechaDesde2);
                        panel2.Controls.Add(dateTimePicker2);

                        panel2.Controls.Add(lblFechaHasta2);
                        panel2.Controls.Add(dateTimePickerRight2);


                   
                        break;

                    case 3:
                        Label lblEmpresa3 = new Label();
                        lblEmpresa3.Size = new System.Drawing.Size(130, 20);
                        lblEmpresa3.Text = "Empresa";
                        lblEmpresa3.Location = new Point(126,  20);
                        lblEmpresa3.Visible = true;

                         txtEmpresa3 = new TextBox();
                        txtEmpresa3.Size = new System.Drawing.Size(130, 20);
                        txtEmpresa3.Location = new Point(126, 43);
                        txtEmpresa3.Visible = true;

                        Label lbPuesto3 = new Label();
                        lbPuesto3.Size = new System.Drawing.Size(130, 20);
                        lbPuesto3.Text = "Puesto Ocupado";
                        lbPuesto3.Location = new Point(120, 70);
                        lbPuesto3.Visible = true;

                         txtPuesto3 = new TextBox();
                        txtPuesto3.Size = new System.Drawing.Size(130, 20);
                        txtPuesto3.Location = new Point(120, 92);
                        txtPuesto3.Visible = true;


                        Label lblSalario3 = new Label();
                        lblSalario3.Size = new System.Drawing.Size(130, 20);
                        lblSalario3.Text = "Salario";
                        lblSalario3.Location = new Point(150, 120);
                        lblSalario3.Visible = true;

                         txtSalario3 = new TextBox();
                        txtSalario3.Size = new System.Drawing.Size(130, 20);
                        txtSalario3.Location = new Point(120, 141);
                        txtSalario3.Visible = true;

                        Label lblFechaDesde3 = new Label();
                        lblFechaDesde3.Size = new System.Drawing.Size(130, 20);
                        lblFechaDesde3.Text = "Fecha Desde";
                        lblFechaDesde3.Location = new Point(33, 170);
                        lblFechaDesde3.Visible = true;

                         dateTimePicker3 = new DateTimePicker();
                        dateTimePicker3.Size = new System.Drawing.Size(100, 20);
                        dateTimePicker3.Location = new Point(18, 196);
                        dateTimePicker3.Format = DateTimePickerFormat.Custom;
                        dateTimePicker3.Visible = true;


                        Label lblFechaHasta3 = new Label();
                        lblFechaHasta3.Size = new System.Drawing.Size(130, 20);
                        lblFechaHasta3.Text = "Fecha hasta";
                        lblFechaHasta3.Location = new Point(211, 170);
                        lblFechaHasta3.Visible = true;

                         dateTimePickerRight3 = new DateTimePicker();
                        dateTimePickerRight3.Size = new System.Drawing.Size(100, 20);
                        dateTimePickerRight3.Location = new Point(190, 196);
                        dateTimePickerRight3.Format = DateTimePickerFormat.Custom;
                        dateTimePickerRight3.Visible = true;


                        panel3.Controls.Add(lblEmpresa3);
                        panel3.Controls.Add(txtEmpresa3);

                        panel3.Controls.Add(lbPuesto3);
                        panel3.Controls.Add(txtPuesto3);

                        panel3.Controls.Add(lblSalario3);
                        panel3.Controls.Add(txtSalario3);

                        panel3.Controls.Add(lblFechaDesde3);
                        panel3.Controls.Add(dateTimePicker3);


                        panel3.Controls.Add(lblFechaHasta3);
                        panel3.Controls.Add(dateTimePickerRight3);

                        break;

                    default:
                        break;
                }

            }
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crearinputs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= CantidadInput; i++)
            {
                switch (i)
                {
                    case 1:

                        experienciaLaboraCandidatos.Add( 
                            new ExperienciaLaboraCandidato 
                            {
                                Empresa = txtEmpresa1.Text,
                                Puesto = txtPuesto.Text,
                                Salario = double.Parse(txtSalario.Text, NumberStyles.Currency),
                                FechaDesde = dateTimePicker.Text,
                                FechaHasta = dateTimePickerRight.Text

                            });

                        break;

                    case 2:

                        experienciaLaboraCandidatos.Add(
                           new ExperienciaLaboraCandidato
                           {
                               Empresa = txtEmpresa2.Text,
                               Puesto = txtPuesto2.Text,
                               Salario = double.Parse(txtSalario2.Text, NumberStyles.Currency),
                               FechaDesde = dateTimePicker2.Text,
                               FechaHasta = dateTimePickerRight2.Text

                           });

                        break;

                    case 3:

                        experienciaLaboraCandidatos.Add(
                           new ExperienciaLaboraCandidato
                           {
                               Empresa = txtEmpresa3.Text,
                               Puesto = txtPuesto3.Text,
                               Salario = double.Parse(txtSalario3.Text, NumberStyles.Currency),
                               FechaDesde = dateTimePicker3.Text,
                               FechaHasta = dateTimePickerRight3.Text

                           });

                        break;


                    default:
                        break;
                }
            }

            var frmCandidato = new FrmCandidato.FrmCandidato(experienciaLaboraCandidatos);
            experienciaLaboraCandidatos.Clear();
            this.Hide();


        }
    }
}
