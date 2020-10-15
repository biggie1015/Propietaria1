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

namespace RecursosHumanos.FrmSelectCapacitacion
{
    public partial class FrmSelectedCapacitacion : Form
    {
        private GCandidatosLogic GCandidatosLogic = null;
        private GCapacitacionLogic capacitacionLogic = null;
        protected static List<CheckCapacitacion> checkCapacitacions = new List<CheckCapacitacion>();

        public FrmSelectedCapacitacion()
        {
            InitializeComponent();
            GCandidatosLogic = new GCandidatosLogic();
            capacitacionLogic = new GCapacitacionLogic();
           
        }

        public FrmSelectedCapacitacion(List<CheckCapacitacion>  capacitacions )
        {
            InitializeComponent();
            GCandidatosLogic = new GCandidatosLogic();
            capacitacionLogic = new GCapacitacionLogic();
            checkCapacitacions.Clear();
            checkCapacitacions.AddRange(capacitacions);
          
        }

        private void FrmSelectedCapacitacion_Load(object sender, EventArgs e)
        {
            dgvCapacitacion.DataSource = capacitacionLogic.GetAll();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvCapacitacion.Columns.Insert(0, checkBoxColumn);
            if (checkCapacitacions.Count > 0)
            {
                GetCheck();
            }

            dgvCapacitacion.Columns["NivelID"].Visible = false;
        }

        private void SeleccionSave_Click(object sender, EventArgs e)
        {
            checkCapacitacions.Clear();


            foreach (DataGridViewRow row in dgvCapacitacion.Rows)
            {
                
                bool isSelected = Convert.ToBoolean(row.Cells[0].EditedFormattedValue);
                if (isSelected)
                {
                    checkCapacitacions.Add(new CheckCapacitacion { Estado = isSelected, Columna = Convert.ToInt32(row.Cells["Id"].Value.ToString()) });
                }
                
            }
            var form =  new  FrmCandidato.FrmCandidato();
            form.SaveFormSelected(checkCapacitacions);
            this.Hide();
        } 


        private void GetCheck()
        {
           
            foreach (DataGridViewRow row in dgvCapacitacion.Rows)
            {
                var col = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                var valorColumna = checkCapacitacions.Where(x => x.Columna == col).Select(y => y.Estado).FirstOrDefault();
                row.Cells["checkBoxColumn"].Value = valorColumna;
               
            }
        }

        public class CheckCapacitacion
        {
            public bool Estado { get; set; }

            public int Columna { get; set; }
        }
    }
}
