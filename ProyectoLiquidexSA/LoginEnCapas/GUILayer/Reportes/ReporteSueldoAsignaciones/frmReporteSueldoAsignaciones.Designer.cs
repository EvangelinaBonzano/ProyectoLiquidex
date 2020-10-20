namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteSueldoAsignaciones
{
    partial class frmReporteSueldoAsignaciones
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboAsignaciones = new System.Windows.Forms.ComboBox();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.rptSueldoAsignaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosReporteSueldoAsignaciones = new ProyectoLiquidexSA.DatosReporteSueldoAsignaciones();
            this.dTSueldoAsignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterSueldoAsignaciones = new ProyectoLiquidexSA.DatosReporteSueldoAsignacionesTableAdapters.TableAdapterSueldoAsignaciones();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteSueldoAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSueldoAsignacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboAsignaciones);
            this.grpFiltros.Controls.Add(this.lblAsignacion);
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Controls.Add(this.cboUsuarios);
            this.grpFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpFiltros.Controls.Add(this.chkTodos);
            this.grpFiltros.Controls.Add(this.btnGenerarReporte);
            this.grpFiltros.Location = new System.Drawing.Point(33, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(732, 108);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // cboAsignaciones
            // 
            this.cboAsignaciones.FormattingEnabled = true;
            this.cboAsignaciones.Location = new System.Drawing.Point(340, 63);
            this.cboAsignaciones.Name = "cboAsignaciones";
            this.cboAsignaciones.Size = new System.Drawing.Size(121, 21);
            this.cboAsignaciones.TabIndex = 10;
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Location = new System.Drawing.Point(272, 66);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(62, 13);
            this.lblAsignacion.TabIndex = 9;
            this.lblAsignacion.Text = "Asignación:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(340, 21);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(265, 21);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(23, 27);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(101, 63);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cboUsuarios.TabIndex = 4;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(101, 21);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(620, 21);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 1;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(620, 61);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(106, 23);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // rptSueldoAsignaciones
            // 
            reportDataSource1.Name = "DatosSueldoAsignaciones";
            reportDataSource1.Value = this.dTSueldoAsignacionesBindingSource;
            this.rptSueldoAsignaciones.LocalReport.DataSources.Add(reportDataSource1);
            this.rptSueldoAsignaciones.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.ReporteSueldoAsignaciones.ReporteSueldoAsign" +
    "aciones.rdlc";
            this.rptSueldoAsignaciones.Location = new System.Drawing.Point(33, 126);
            this.rptSueldoAsignaciones.Name = "rptSueldoAsignaciones";
            this.rptSueldoAsignaciones.ServerReport.BearerToken = null;
            this.rptSueldoAsignaciones.Size = new System.Drawing.Size(736, 349);
            this.rptSueldoAsignaciones.TabIndex = 2;
            // 
            // datosReporteSueldoAsignaciones
            // 
            this.datosReporteSueldoAsignaciones.DataSetName = "DatosReporteSueldoAsignaciones";
            this.datosReporteSueldoAsignaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTSueldoAsignacionesBindingSource
            // 
            this.dTSueldoAsignacionesBindingSource.DataMember = "DTSueldoAsignaciones";
            this.dTSueldoAsignacionesBindingSource.DataSource = this.datosReporteSueldoAsignaciones;
            // 
            // tableAdapterSueldoAsignaciones
            // 
            this.tableAdapterSueldoAsignaciones.ClearBeforeFill = true;
            // 
            // frmReporteSueldoAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 487);
            this.Controls.Add(this.rptSueldoAsignaciones);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmReporteSueldoAsignaciones";
            this.Text = "Reporte Sueldo Asignaciones";
            this.Load += new System.EventHandler(this.frmReporteSueldoAsignaciones_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteSueldoAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSueldoAsignacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cboAsignaciones;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rptSueldoAsignaciones;
        private DatosReporteSueldoAsignaciones datosReporteSueldoAsignaciones;
        private System.Windows.Forms.BindingSource dTSueldoAsignacionesBindingSource;
        private DatosReporteSueldoAsignacionesTableAdapters.TableAdapterSueldoAsignaciones tableAdapterSueldoAsignaciones;
    }
}