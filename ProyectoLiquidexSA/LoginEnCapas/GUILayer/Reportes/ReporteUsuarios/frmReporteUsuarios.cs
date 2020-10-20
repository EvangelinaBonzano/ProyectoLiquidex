using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLiquidexSA.BusinessLayer;
using Microsoft.Reporting.WinForms;

namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteUsuarios
{
    public partial class frmReporteUsuarios : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;

        public frmReporteUsuarios()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosReporteUsuarios.DatosUsuario' Puede moverla o quitarla según sea necesario.
            this.datosUsuarioTableAdapter.Fill(this.datosReporteUsuarios.DatosUsuario);
            // TODO: esta línea de código carga datos en la tabla 'datosReporteUsuarios.DatosUsuario' Puede moverla o quitarla según sea necesario.
            this.datosUsuarioTableAdapter.Fill(this.datosReporteUsuarios.DatosUsuario);
            // TODO: esta línea de código carga datos en la tabla 'datosReporteUsuarios.DatosUsuario' Puede moverla o quitarla según sea necesario.
            //this.datosUsuarioTableAdapter.Fill(this.datosReporteUsuarios.DatosUsuario);
            this.CenterToParent();
            this.cargarCombo(cboUsuario, oUsuarioService.ObtenerTodos(), "NombreUsuario", "IdUsuario");
            this.cargarCombo(cboPerfiles, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = "SELECT u.usuario AS usuario, " +
                                    "        u.email as email, " +
                                    "        p.nombre as nombre, " +
                                    "        s.sueldo as sueldo " +
                                    "   FROM Usuarios u " +
                                    "  INNER JOIN Perfiles p ON (p.id_perfil = u.id_perfil) " +
                                    "  INNER JOIN SueldoPerfilHistorico s ON (p.id_perfil = s.id_perfil) " +
                                    "  WHERE u.borrado=0 ";

            if (!chkTodos.Checked)
            {

                if (cboUsuario.Text != string.Empty)
                {
                    sql += " AND u.id_usuario =" + cboUsuario.SelectedValue.ToString();
                    cboUsuario.SelectedIndex = -1;
                    rptListadoUsuarios.LocalReport.DataSources.Clear();
                    rptListadoUsuarios.LocalReport.DataSources.Add(new ReportDataSource("DatosUsuario", oDm.ConsultaSQL(sql)));
                    rptListadoUsuarios.RefreshReport();

                }
                if (cboPerfiles.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += "  AND p.id_perfil =" + cboPerfiles.SelectedValue.ToString();
                    cboPerfiles.SelectedIndex = -1;
                    rptListadoUsuarios.LocalReport.DataSources.Clear();
                    rptListadoUsuarios.LocalReport.DataSources.Add(new ReportDataSource("DatosUsuario", oDm.ConsultaSQL(sql)));
                    rptListadoUsuarios.RefreshReport();
                }
            }
            else
            {
                rptListadoUsuarios.LocalReport.DataSources.Clear();
                rptListadoUsuarios.LocalReport.DataSources.Add(new ReportDataSource("DatosUsuario", oDm.ConsultaSQL(sql)));
                rptListadoUsuarios.RefreshReport();
                this.rptListadoUsuarios.RefreshReport();
                chkTodos.Checked = false;
            }
        }
        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
