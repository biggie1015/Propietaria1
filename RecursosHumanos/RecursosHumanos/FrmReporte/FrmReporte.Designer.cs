namespace RecursosHumanos.FrmReporte
{
    partial class FrmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gEmpleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.propietaria1DataSet = new RecursosHumanos.Propietaria1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gEmpleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gEmpleadosTableAdapter1 = new RecursosHumanos.Propietaria1DataSetTableAdapters.GEmpleadosTableAdapter();
            this.reporteEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteEmpleados = new RecursosHumanos.ReporteEmpleados();
            this.gEmpleadosTableAdapter = new RecursosHumanos.ReporteEmpleadosTableAdapters.GEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietaria1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gEmpleadosBindingSource2
            // 
            this.gEmpleadosBindingSource2.DataMember = "GEmpleados";
            this.gEmpleadosBindingSource2.DataSource = this.propietaria1DataSet;
            // 
            // propietaria1DataSet
            // 
            this.propietaria1DataSet.DataSetName = "Propietaria1DataSet";
            this.propietaria1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gEmpleadosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RecursosHumanos.ReporteEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1147, 574);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // gEmpleadosBindingSource
            // 
            this.gEmpleadosBindingSource.DataMember = "GEmpleados";
            this.gEmpleadosBindingSource.DataSource = this.reporteEmpleadosBindingSource;
            // 
            // gEmpleadosBindingSource1
            // 
            this.gEmpleadosBindingSource1.DataMember = "GEmpleados";
            this.gEmpleadosBindingSource1.DataSource = this.reporteEmpleadosBindingSource;
            // 
            // gEmpleadosTableAdapter1
            // 
            this.gEmpleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // reporteEmpleadosBindingSource
            // 
            this.reporteEmpleadosBindingSource.DataSource = this.reporteEmpleados;
            this.reporteEmpleadosBindingSource.Position = 0;
            // 
            // reporteEmpleados
            // 
            this.reporteEmpleados.DataSetName = "ReporteEmpleados";
            this.reporteEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gEmpleadosTableAdapter
            // 
            this.gEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 574);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietaria1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gEmpleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteEmpleadosBindingSource;
        private ReporteEmpleados reporteEmpleados;
        private System.Windows.Forms.BindingSource gEmpleadosBindingSource;
        private ReporteEmpleadosTableAdapters.GEmpleadosTableAdapter gEmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource gEmpleadosBindingSource1;
        private Propietaria1DataSet propietaria1DataSet;
        private System.Windows.Forms.BindingSource gEmpleadosBindingSource2;
        private Propietaria1DataSetTableAdapters.GEmpleadosTableAdapter gEmpleadosTableAdapter1;
    }
}