using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusnnessLogic.RecursosHumanos;
using RecursosHumanos.FrmCandidato;

namespace RecursosHumanos.FrmLogin
{
    public partial class FrmLogin : Form
    {
        private GEmpleadosLogic GEmpleadosLogic;
        public FrmLogin()
        {
            InitializeComponent();
            GEmpleadosLogic = new GEmpleadosLogic();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwm, int wsg, int waprm, int param);
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Nombre";
                txtUser.ForeColor = Color.DimGray;
           
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Nombre")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }

        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;


            if(GEmpleadosLogic.InicioSeccion(user) > 0 && password == "123456")
            {
                var frmPincipal = new FrmPrincipal.VistaPrincipal();
                this.Hide();
                frmPincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contrasena erroneas.");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmCandidatos = new FrmCandidato.FrmCandidato();
            this.Hide();
            frmCandidatos.Show();
        }
    }
}
