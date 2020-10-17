namespace RecursosHumanos.FrmDetalleCandidatos
{
    partial class FrmDetalleCandidatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCandidatoIdiomas = new System.Windows.Forms.DataGridView();
            this.dgvCandidatoCompetencia = new System.Windows.Forms.DataGridView();
            this.dgvCandidatoCapacitaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoCompetencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoCapacitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idiomas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Competencias";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacitaciones";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvCandidatoIdiomas
            // 
            this.dgvCandidatoIdiomas.AllowUserToDeleteRows = false;
            this.dgvCandidatoIdiomas.AllowUserToOrderColumns = true;
            this.dgvCandidatoIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatoIdiomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidatoIdiomas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatoIdiomas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatoIdiomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatoIdiomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatoIdiomas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidatoIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatoIdiomas.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatoIdiomas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidatoIdiomas.Location = new System.Drawing.Point(56, 77);
            this.dgvCandidatoIdiomas.Name = "dgvCandidatoIdiomas";
            this.dgvCandidatoIdiomas.ReadOnly = true;
            this.dgvCandidatoIdiomas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCandidatoIdiomas.RowHeadersVisible = false;
            this.dgvCandidatoIdiomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCandidatoIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatoIdiomas.Size = new System.Drawing.Size(303, 228);
            this.dgvCandidatoIdiomas.TabIndex = 20;
            // 
            // dgvCandidatoCompetencia
            // 
            this.dgvCandidatoCompetencia.AllowUserToDeleteRows = false;
            this.dgvCandidatoCompetencia.AllowUserToOrderColumns = true;
            this.dgvCandidatoCompetencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatoCompetencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidatoCompetencia.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatoCompetencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatoCompetencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatoCompetencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatoCompetencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCandidatoCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatoCompetencia.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatoCompetencia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCandidatoCompetencia.Location = new System.Drawing.Point(48, 361);
            this.dgvCandidatoCompetencia.Name = "dgvCandidatoCompetencia";
            this.dgvCandidatoCompetencia.ReadOnly = true;
            this.dgvCandidatoCompetencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCandidatoCompetencia.RowHeadersVisible = false;
            this.dgvCandidatoCompetencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCandidatoCompetencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatoCompetencia.Size = new System.Drawing.Size(311, 216);
            this.dgvCandidatoCompetencia.TabIndex = 20;
            // 
            // dgvCandidatoCapacitaciones
            // 
            this.dgvCandidatoCapacitaciones.AllowUserToDeleteRows = false;
            this.dgvCandidatoCapacitaciones.AllowUserToOrderColumns = true;
            this.dgvCandidatoCapacitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatoCapacitaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidatoCapacitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatoCapacitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatoCapacitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatoCapacitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatoCapacitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCandidatoCapacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatoCapacitaciones.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatoCapacitaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCandidatoCapacitaciones.Location = new System.Drawing.Point(628, 77);
            this.dgvCandidatoCapacitaciones.Name = "dgvCandidatoCapacitaciones";
            this.dgvCandidatoCapacitaciones.ReadOnly = true;
            this.dgvCandidatoCapacitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCandidatoCapacitaciones.RowHeadersVisible = false;
            this.dgvCandidatoCapacitaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCandidatoCapacitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatoCapacitaciones.Size = new System.Drawing.Size(345, 251);
            this.dgvCandidatoCapacitaciones.TabIndex = 20;
            // 
            // FrmDetalleCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 589);
            this.Controls.Add(this.dgvCandidatoCompetencia);
            this.Controls.Add(this.dgvCandidatoCapacitaciones);
            this.Controls.Add(this.dgvCandidatoIdiomas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleCandidatos";
            this.Text = "FrmDetalleCandidatos";
            this.Load += new System.EventHandler(this.FrmDetalleCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoCompetencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatoCapacitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCandidatoIdiomas;
        private System.Windows.Forms.DataGridView dgvCandidatoCompetencia;
        private System.Windows.Forms.DataGridView dgvCandidatoCapacitaciones;
    }
}