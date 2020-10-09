using RecursosHumanos.FrmCompetencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmPrincipal
{
    public partial class VistaPrincipal : Form
    {

        private Form Form = null;

        public VistaPrincipal()
        {
            InitializeComponent();
        }


        public void AllSize()
        {
            //this.close.Left += 400;
            //this.Minimized.Left += 395;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal(object sender, EventArgs e)
        {
            AllSize();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeColorButtons(Bunifu.Framework.UI.BunifuFlatButton sender) 
        { 
        
        }


        private void ChangeViewForm(Form formChild)
        {
            if(this.Form != null)
            {
                this.Form.Close();
            }

            this.Form = formChild;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;
            Central.Controls.Add(formChild);
            Central.Tag = formChild;
            Central.BringToFront();
            formChild.Show();
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            ChangeViewForm(new FrmComptenecia());
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
