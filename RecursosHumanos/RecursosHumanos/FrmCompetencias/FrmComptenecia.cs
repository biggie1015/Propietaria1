using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmCompetencias
{
    public partial class FrmComptenecia : Form
    {
        public FrmComptenecia()
        {
            InitializeComponent();
            
        }

        private void FrmComptenecia_Load(object sender, EventArgs e)
        {
            Competencia competencia = new Competencia();
            competencia.ID = 15;
            competencia.Descripcion = "Desarrollo Web";
            dgvCompetencias.Columns.Add("ID","ID");
            dgvCompetencias.Columns.Add("Descripcion", "Descripcion");
            dgvCompetencias.Rows.Add("32","Desarrollo Web");
            dgvCompetencias.Rows.Add("14", "Desarrollo Angular");
            //lblCompetencias.Left = (lblCompetencias.Parent.Width - lblCompetencias.Width) / 2;
            //lblCompetencias.Top = (lblCompetencias.Parent.Height - lblCompetencias.Height) / 2;

        }

        private void dgvCompetencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string prueba="";
        }
    }

    class Competencia
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
