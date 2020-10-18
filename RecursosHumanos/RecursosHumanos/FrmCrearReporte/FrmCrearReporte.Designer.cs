namespace RecursosHumanos.FrmCrearReporte
{
    partial class FrmCrearReporte
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
            this.timeDesde = new System.Windows.Forms.DateTimePicker();
            this.timeHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // timeDesde
            // 
            this.timeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDesde.Location = new System.Drawing.Point(82, 88);
            this.timeDesde.Name = "timeDesde";
            this.timeDesde.Size = new System.Drawing.Size(110, 20);
            this.timeDesde.TabIndex = 0;
            // 
            // timeHasta
            // 
            this.timeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeHasta.Location = new System.Drawing.Point(539, 88);
            this.timeHasta.Name = "timeHasta";
            this.timeHasta.Size = new System.Drawing.Size(106, 20);
            this.timeHasta.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Desde";
            // 
            // btnReporte
            // 
            this.btnReporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.BorderRadius = 7;
            this.btnReporte.ButtonText = "Crear Reporte";
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReporte.Iconimage = null;
            this.btnReporte.Iconimage_right = null;
            this.btnReporte.Iconimage_right_Selected = null;
            this.btnReporte.Iconimage_Selected = null;
            this.btnReporte.IconMarginLeft = 0;
            this.btnReporte.IconMarginRight = 0;
            this.btnReporte.IconRightVisible = true;
            this.btnReporte.IconRightZoom = 0D;
            this.btnReporte.IconVisible = true;
            this.btnReporte.IconZoom = 50D;
            this.btnReporte.IsTab = false;
            this.btnReporte.Location = new System.Drawing.Point(256, 262);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReporte.selected = false;
            this.btnReporte.Size = new System.Drawing.Size(289, 33);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Crear Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReporte.Textcolor = System.Drawing.Color.White;
            this.btnReporte.TextFont = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FrmCrearReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 574);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeHasta);
            this.Controls.Add(this.timeDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearReporte";
            this.Text = "FrmCrearReporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeDesde;
        private System.Windows.Forms.DateTimePicker timeHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReporte;
    }
}