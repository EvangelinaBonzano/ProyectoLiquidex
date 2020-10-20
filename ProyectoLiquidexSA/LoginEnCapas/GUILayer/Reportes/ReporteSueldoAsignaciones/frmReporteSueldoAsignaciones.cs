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

namespace ProyectoLiquidexSA.GUILayer.Reportes.ReporteSueldoAsignaciones
{
    public partial class frmReporteSueldoAsignaciones : Form
    {
        private UsuarioService oUsuarioService;
        private AsignacionService oAsignacionService;
        public frmReporteSueldoAsignaciones()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oAsignacionService = new AsignacionService();
        }

        private void frmReporteSueldoAsignaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosReporteSueldoAsignaciones.DTSueldoAsignaciones' Puede moverla o quitarla según sea necesario.
            //this.tableAdapterSueldoAsignaciones.Fill(this.datosReporteSueldoAsignaciones.DTSueldoAsignaciones);
            this.CenterToParent();
            this.cargarCombo(cboUsuarios, oUsuarioService.ObtenerTodos(), "NombreUsuario", "IdUsuario");
            this.cargarCombo(cboAsignaciones, oAsignacionService.ObtenerTodos(), "N_asignacion", "Id_asignacion");

        }
        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = "SELECT Usuarios.usuario, " +
                                    "        SueldoAsignaciones.fecha, " +
                                    "        Asignaciones.n_asignacion, " +
                                    "        SueldoAsignaciones.monto,  " +
                                    "        SueldoAsignaciones.cantidad " +
                                    "   FROM SueldoAsignaciones" +
                                    "  INNER JOIN Asignaciones ON SueldoAsignaciones.id_asignacion = Asignaciones.id_asignacion " +
                                    "  INNER JOIN Usuarios ON SueldoAsignaciones.id_usuario = Usuarios.id_usuario " +
                                    "  WHERE SueldoAsignaciones.borrado=0 ";


            if (!chkTodos.Checked)
            {
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("Fechas erroneas!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    dtpFechaDesde.Focus();
                    return;
                }
                else
                {
                    sql += " AND SueldoAsignaciones.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
                    rptSueldoAsignaciones.LocalReport.DataSources.Clear();
                    rptSueldoAsignaciones.LocalReport.DataSources.Add(new ReportDataSource("DatosSueldoAsignaciones", oDm.ConsultaSQL(sql)));
                    rptSueldoAsignaciones.RefreshReport();
                }
                if (cboAsignaciones.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += " AND Asignaciones.id_asignacion=" + cboAsignaciones.SelectedValue.ToString();
                    cboAsignaciones.SelectedIndex = -1;
                    rptSueldoAsignaciones.LocalReport.DataSources.Clear();
                    rptSueldoAsignaciones.LocalReport.DataSources.Add(new ReportDataSource("DatosSueldoAsignaciones", oDm.ConsultaSQL(sql)));
                    rptSueldoAsignaciones.RefreshReport();

                }
                if (cboUsuarios.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += "  AND Usuarios.id_usuario=" + cboUsuarios.SelectedValue.ToString();
                    cboUsuarios.SelectedIndex = -1;
                    rptSueldoAsignaciones.LocalReport.DataSources.Clear();
                    rptSueldoAsignaciones.LocalReport.DataSources.Add(new ReportDataSource("DatosSueldoAsignaciones", oDm.ConsultaSQL(sql)));
                    rptSueldoAsignaciones.RefreshReport();
                }

            }
            else
            {
                rptSueldoAsignaciones.LocalReport.DataSources.Clear();
                rptSueldoAsignaciones.LocalReport.DataSources.Add(new ReportDataSource("DatosSueldoAsignaciones", oDm.ConsultaSQL(sql)));
                rptSueldoAsignaciones.RefreshReport();
                this.rptSueldoAsignaciones.RefreshReport();
                chkTodos.Checked = false;
            }
        }
    }
}
