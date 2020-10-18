using RecursosHumanos.FrmReporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmCrearReporte
{
    public partial class FrmCrearReporte : Form
    {
        public FrmCrearReporte()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var frmReporte = new FrmReporte.FrmReporte();
             
            frmReporte.FiltrarData(timeDesde.Text, timeHasta.Text);

        }
    }
}
