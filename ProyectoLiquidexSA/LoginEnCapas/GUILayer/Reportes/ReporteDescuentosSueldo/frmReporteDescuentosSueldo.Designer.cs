namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteDescuentosSueldo
{
    partial class frmReporteDescuentosSueldo
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
            this.datosReporteDescuentosSueldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosReporteDescuentosSueldo = new ProyectoLiquidexSA.DatosReporteDescuentosSueldo();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cboNombresUsuario = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDescuentosSueldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDescuentosSueldo)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosReporteDescuentosSueldoBindingSource
            // 
            this.datosReporteDescuentosSueldoBindingSource.DataSource = this.datosReporteDescuentosSueldo;
            this.datosReporteDescuentosSueldoBindingSource.Position = 0;
            // 
            // datosReporteDescuentosSueldo
            // 
            this.datosReporteDescuentosSueldo.DataSetName = "DatosReporteDescuentosSueldo";
            this.datosReporteDescuentosSueldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Controls.Add(this.cboNombresUsuario);
            this.grpFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpFiltros.Controls.Add(this.chkTodos);
            this.grpFiltros.Controls.Add(this.btnGenerarReporte);
            this.grpFiltros.Location = new System.Drawing.Point(107, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(587, 108);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
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
            // cboNombresUsuario
            // 
            this.cboNombresUsuario.FormattingEnabled = true;
            this.cboNombresUsuario.Location = new System.Drawing.Point(101, 63);
            this.cboNombresUsuario.Name = "cboNombresUsuario";
            this.cboNombresUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboNombresUsuario.TabIndex = 4;
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
            this.chkTodos.Location = new System.Drawing.Point(268, 67);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 1;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(467, 67);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(106, 23);
            this.btnGenerarReporte.TabIndex = 0;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DatosDescuentosSueldo";
            reportDataSource1.Value = this.datosReporteDescuentosSueldoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.ReporteDescuentosSueldo.ReporteDescuentosSue" +
    "ldo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 312);
            this.reportViewer1.TabIndex = 2;
            // 
            // frmReporteDescuentosSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmReporteDescuentosSueldo";
            this.Text = "Reporte Descuentos De Sueldos";
            this.Load += new System.EventHandler(this.frmReporteDescuentosSueldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDescuentosSueldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDescuentosSueldo)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cboNombresUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosReporteDescuentosSueldoBindingSource;
        private DatosReporteDescuentosSueldo datosReporteDescuentosSueldo;
    }
}