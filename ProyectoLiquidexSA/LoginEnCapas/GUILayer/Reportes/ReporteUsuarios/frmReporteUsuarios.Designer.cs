namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteUsuarios
{
    partial class frmReporteUsuarios
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
            this.datosUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosReporteUsuarios = new ProyectoLiquidexSA.DatosReporteUsuarios();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rptListadoUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosUsuarioTableAdapter = new ProyectoLiquidexSA.DatosReporteUsuariosTableAdapters.DatosUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // datosUsuarioBindingSource
            // 
            this.datosUsuarioBindingSource.DataMember = "DatosUsuario";
            this.datosUsuarioBindingSource.DataSource = this.datosReporteUsuarios;
            // 
            // datosReporteUsuarios
            // 
            this.datosReporteUsuarios.DataSetName = "DatosReporteUsuarios";
            this.datosReporteUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(101, 31);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 21);
            this.cboUsuario.TabIndex = 13;
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(310, 31);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(142, 21);
            this.cboPerfiles.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "&Perfil:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(396, 73);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 10;
            this.chkTodos.Text = "Todos";
            this.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Usuario:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(501, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(77, 37);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rptListadoUsuarios
            // 
            reportDataSource1.Name = "DatosUsuarios";
            reportDataSource1.Value = this.datosUsuarioBindingSource;
            this.rptListadoUsuarios.LocalReport.DataSources.Add(reportDataSource1);
            this.rptListadoUsuarios.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.ReporteUsuarios.ReporteUsuarios.rdlc";
            this.rptListadoUsuarios.Location = new System.Drawing.Point(1, 104);
            this.rptListadoUsuarios.Name = "rptListadoUsuarios";
            this.rptListadoUsuarios.ServerReport.BearerToken = null;
            this.rptListadoUsuarios.Size = new System.Drawing.Size(723, 415);
            this.rptListadoUsuarios.TabIndex = 14;
            // 
            // datosUsuarioTableAdapter
            // 
            this.datosUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 520);
            this.Controls.Add(this.rptListadoUsuarios);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.cboPerfiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Name = "frmReporteUsuarios";
            this.Text = "Reporte Usuarios";
            this.Load += new System.EventHandler(this.frmReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboPerfiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private Microsoft.Reporting.WinForms.ReportViewer rptListadoUsuarios;
        private DatosReporteUsuarios datosReporteUsuarios;
        private System.Windows.Forms.BindingSource datosUsuarioBindingSource;
        private DatosReporteUsuariosTableAdapters.DatosUsuarioTableAdapter datosUsuarioTableAdapter;
    }
}