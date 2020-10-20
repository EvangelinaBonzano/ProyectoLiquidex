namespace ProyectoLiquidexSA.GUILayer.Reportes
{
    partial class frmReporteListadoAsistencia
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
            this.dTListadoAsistenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datosReporteAsistencia = new ProyectoLiquidexSA.DatosReporteAsistencia();
            this.dTListadoAsistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.rptListadoAsistencia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableAdapterListadoAsistencia = new ProyectoLiquidexSA.DatosReporteAsistenciaTableAdapters.TableAdapterListadoAsistencia();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoAsistenciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoAsistenciaBindingSource)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTListadoAsistenciaBindingSource1
            // 
            this.dTListadoAsistenciaBindingSource1.DataMember = "DTListadoAsistencia";
            this.dTListadoAsistenciaBindingSource1.DataSource = this.datosReporteAsistencia;
            // 
            // datosReporteAsistencia
            // 
            this.datosReporteAsistencia.DataSetName = "DatosReporteAsistencia";
            this.datosReporteAsistencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTListadoAsistenciaBindingSource
            // 
            this.dTListadoAsistenciaBindingSource.DataMember = "DTListadoAsistencia";
            this.dTListadoAsistenciaBindingSource.DataSource = this.datosReporteAsistencia;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboEstados);
            this.grpFiltros.Controls.Add(this.lblEstado);
            this.grpFiltros.Controls.Add(this.lblNombre);
            this.grpFiltros.Controls.Add(this.dtpFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaHasta);
            this.grpFiltros.Controls.Add(this.lblFechaDesde);
            this.grpFiltros.Controls.Add(this.cboUsuarios);
            this.grpFiltros.Controls.Add(this.dtpFechaDesde);
            this.grpFiltros.Controls.Add(this.chkTodos);
            this.grpFiltros.Controls.Add(this.btnGenerarReporte);
            this.grpFiltros.Location = new System.Drawing.Point(22, 21);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(732, 108);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(340, 63);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(291, 66);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
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
            // rptListadoAsistencia
            // 
            this.rptListadoAsistencia.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.ReporteAsistencia.ReporteListadoAsistencia.r" +
    "dlc";
            this.rptListadoAsistencia.Location = new System.Drawing.Point(22, 135);
            this.rptListadoAsistencia.Name = "rptListadoAsistencia";
            this.rptListadoAsistencia.ServerReport.BearerToken = null;
            this.rptListadoAsistencia.Size = new System.Drawing.Size(732, 404);
            this.rptListadoAsistencia.TabIndex = 1;
            // 
            // tableAdapterListadoAsistencia
            // 
            this.tableAdapterListadoAsistencia.ClearBeforeFill = true;
            // 
            // frmReporteListadoAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 551);
            this.Controls.Add(this.rptListadoAsistencia);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmReporteListadoAsistencia";
            this.Text = "Reporte Asistencia";
            this.Load += new System.EventHandler(this.frmReporteListadoAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoAsistenciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoAsistenciaBindingSource)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rptListadoAsistencia;
        private DatosReporteAsistencia datosReporteAsistencia;
        private System.Windows.Forms.BindingSource dTListadoAsistenciaBindingSource;
        private DatosReporteAsistenciaTableAdapters.TableAdapterListadoAsistencia tableAdapterListadoAsistencia;
        private System.Windows.Forms.BindingSource dTListadoAsistenciaBindingSource1;
    }
}