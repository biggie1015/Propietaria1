using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.FrmReporte
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propietaria1DataSet.GEmpleados' table. You can move, or remove it, as needed.
            this.gEmpleadosTableAdapter1.Fill(this.propietaria1DataSet.GEmpleados);
            // TODO: This line of code loads data into the 'reporteEmpleados.GEmpleados' table. You can move, or remove it, as needed.
    

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


        public void FiltrarData(string fechaDesde, string FechaHasta)
        {
            try
            {
             
                this.gEmpleadosTableAdapter.GDEmpleados( fechaDesde, FechaHasta);
          

                this.reportViewer1.RefreshReport();
                this.Show();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
               
            }
         
        }
    }
}
