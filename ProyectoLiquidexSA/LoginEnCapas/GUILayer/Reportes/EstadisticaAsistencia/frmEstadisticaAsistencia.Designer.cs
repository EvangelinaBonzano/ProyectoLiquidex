namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaAsistencia
{
    partial class frmEstadisticaAsistencia
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
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.rptEstadisticaAsistencia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(329, 27);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(254, 28);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(19, 28);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesde.TabIndex = 9;
            this.lblFechaDesde.Text = "Fecha desde:";
            this.lblFechaDesde.Click += new System.EventHandler(this.lblFechaDesde_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(97, 27);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.btnGrafico);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(776, 66);
            this.grpFiltros.TabIndex = 12;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(652, 24);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(109, 23);
            this.btnGrafico.TabIndex = 12;
            this.btnGrafico.Text = "Generar gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.button1_Click);
            // 
            // rptEstadisticaAsistencia
            // 
            this.rptEstadisticaAsistencia.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaAsistencia.EstadisticaAsistencia." +
    "rdlc";
            this.rptEstadisticaAsistencia.Location = new System.Drawing.Point(12, 84);
            this.rptEstadisticaAsistencia.Name = "rptEstadisticaAsistencia";
            this.rptEstadisticaAsistencia.ServerReport.BearerToken = null;
            this.rptEstadisticaAsistencia.Size = new System.Drawing.Size(776, 438);
            this.rptEstadisticaAsistencia.TabIndex = 13;
            // 
            // frmEstadisticaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 534);
            this.Controls.Add(this.rptEstadisticaAsistencia);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmEstadisticaAsistencia";
            this.Text = "Estadística Asistencia";
            this.Load += new System.EventHandler(this.frmEstadisticaAsistencia_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnGrafico;
        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticaAsistencia;
    }
}