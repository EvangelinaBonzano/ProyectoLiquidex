namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaUsuarios
{
    partial class frmEstadisticaUsuarios
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
            this.rptEstadisticaUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptEstadisticaUsuarios
            // 
            this.rptEstadisticaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptEstadisticaUsuarios.LocalReport.ReportEmbeddedResource = "ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaUsuarios.EstadisticaUsuarios.rdlc" +
    "";
            this.rptEstadisticaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.rptEstadisticaUsuarios.Name = "rptEstadisticaUsuarios";
            this.rptEstadisticaUsuarios.ServerReport.BearerToken = null;
            this.rptEstadisticaUsuarios.Size = new System.Drawing.Size(671, 438);
            this.rptEstadisticaUsuarios.TabIndex = 0;
            // 
            // frmEstadisticaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 438);
            this.Controls.Add(this.rptEstadisticaUsuarios);
            this.Name = "frmEstadisticaUsuarios";
            this.Text = "Estadística Usuarios";
            this.Load += new System.EventHandler(this.frmEstadisticaUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEstadisticaUsuarios;
    }
}