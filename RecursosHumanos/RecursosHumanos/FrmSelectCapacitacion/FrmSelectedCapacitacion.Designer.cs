namespace RecursosHumanos.FrmSelectCapacitacion
{
    partial class FrmSelectedCapacitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCapacitacion = new System.Windows.Forms.DataGridView();
            this.lblCompetencias = new System.Windows.Forms.Label();
            this.SeleccionSave = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapacitacion
            // 
            this.dgvCapacitacion.AllowUserToAddRows = false;
            this.dgvCapacitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCapacitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapacitacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCapacitacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvCapacitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapacitacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCapacitacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCapacitacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCapacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCapacitacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCapacitacion.Location = new System.Drawing.Point(12, 143);
            this.dgvCapacitacion.Name = "dgvCapacitacion";
            this.dgvCapacitacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCapacitacion.RowHeadersVisible = false;
            this.dgvCapacitacion.RowHeadersWidth = 60;
            this.dgvCapacitacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCapacitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCapacitacion.Size = new System.Drawing.Size(783, 217);
            this.dgvCapacitacion.TabIndex = 3;
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencias.Location = new System.Drawing.Point(221, 19);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(405, 33);
            this.lblCompetencias.TabIndex = 18;
            this.lblCompetencias.Text = "Selección de Capacitaciones";
            this.lblCompetencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeleccionSave
            // 
            this.SeleccionSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.SeleccionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.SeleccionSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeleccionSave.BorderRadius = 7;
            this.SeleccionSave.ButtonText = "Guardar Selección";
            this.SeleccionSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeleccionSave.DisabledColor = System.Drawing.Color.Gray;
            this.SeleccionSave.Iconcolor = System.Drawing.Color.Transparent;
            this.SeleccionSave.Iconimage = null;
            this.SeleccionSave.Iconimage_right = null;
            this.SeleccionSave.Iconimage_right_Selected = null;
            this.SeleccionSave.Iconimage_Selected = null;
            this.SeleccionSave.IconMarginLeft = 0;
            this.SeleccionSave.IconMarginRight = 0;
            this.SeleccionSave.IconRightVisible = true;
            this.SeleccionSave.IconRightZoom = 0D;
            this.SeleccionSave.IconVisible = true;
            this.SeleccionSave.IconZoom = 50D;
            this.SeleccionSave.IsTab = false;
            this.SeleccionSave.Location = new System.Drawing.Point(281, 384);
            this.SeleccionSave.Name = "SeleccionSave";
            this.SeleccionSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.SeleccionSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(139)))), ((int)(((byte)(192)))));
            this.SeleccionSave.OnHoverTextColor = System.Drawing.Color.White;
            this.SeleccionSave.selected = false;
            this.SeleccionSave.Size = new System.Drawing.Size(245, 35);
            this.SeleccionSave.TabIndex = 43;
            this.SeleccionSave.Text = "Guardar Selección";
            this.SeleccionSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeleccionSave.Textcolor = System.Drawing.Color.White;
            this.SeleccionSave.TextFont = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionSave.Click += new System.EventHandler(this.SeleccionSave_Click);
            // 
            // FrmSelectedCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.SeleccionSave);
            this.Controls.Add(this.lblCompetencias);
            this.Controls.Add(this.dgvCapacitacion);
            this.Name = "FrmSelectedCapacitacion";
            this.Text = "FrmSelectedCapacitacion";
            this.Load += new System.EventHandler(this.FrmSelectedCapacitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapacitacion;
        private System.Windows.Forms.Label lblCompetencias;
        private Bunifu.Framework.UI.BunifuFlatButton SeleccionSave;
    }
}