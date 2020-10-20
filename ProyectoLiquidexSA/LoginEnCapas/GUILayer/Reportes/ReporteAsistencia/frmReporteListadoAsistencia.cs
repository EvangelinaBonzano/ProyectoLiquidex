using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ProyectoLiquidexSA.BusinessLayer;


namespace ProyectoLiquidexSA.GUILayer.Reportes
{
    public partial class frmReporteListadoAsistencia : Form
    {
        private UsuarioService oUsuarioService;
        private EstadosAsistenciaService oEstadosAsistenciaService;
        private AsistenciaService oAsistenciaService;
        public frmReporteListadoAsistencia()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oEstadosAsistenciaService = new EstadosAsistenciaService();
            oAsistenciaService = new AsistenciaService();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = "SELECT u.usuario AS usuario, " +
                                    "        e.n_estados_asistencia AS n_estados_asistencia, " +
                                    "        a.fecha as fecha, " +
                                    "        a.hora_ingreso AS hora_ingreso, " +
                                    "        a.hora_salida AS hora_salida " +
                                    "   FROM AsistenciaUsuarios a" +
                                    "  INNER JOIN EstadosAsistencia e ON (a.id_estado_asistencia=e.id_estado_asistencia) " +
                                    "  INNER JOIN Usuarios u ON (a.id_usuario=u.id_usuario) " +
                                    "  WHERE a.borrado=0 ";
                                   

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
                    sql += " AND a.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
                    rptListadoAsistencia.LocalReport.DataSources.Clear();
                    rptListadoAsistencia.LocalReport.DataSources.Add(new ReportDataSource("DatosAsistencia", oDm.ConsultaSQL(sql)));
                    rptListadoAsistencia.RefreshReport();
                }
                if (cboEstados.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += " AND e.id_estado_asistencia=" + cboEstados.SelectedValue.ToString();
                    cboEstados.SelectedIndex = -1;
                    rptListadoAsistencia.LocalReport.DataSources.Clear();
                    rptListadoAsistencia.LocalReport.DataSources.Add(new ReportDataSource("DatosAsistencia", oDm.ConsultaSQL(sql)));
                    rptListadoAsistencia.RefreshReport();

                }
                if (cboUsuarios.Text != string.Empty)
                {
                    // Si el combo tiene un estado seleccionado, la recuperamos con el value
                    sql += "  AND u.id_usuario =" + cboUsuarios.SelectedValue.ToString();
                    cboUsuarios.SelectedIndex = -1;
                    rptListadoAsistencia.LocalReport.DataSources.Clear();
                    rptListadoAsistencia.LocalReport.DataSources.Add(new ReportDataSource("DatosAsistencia", oDm.ConsultaSQL(sql)));
                    rptListadoAsistencia.RefreshReport();

                }

            }
            else
            {
                rptListadoAsistencia.LocalReport.DataSources.Clear();
                rptListadoAsistencia.LocalReport.DataSources.Add(new ReportDataSource("DatosAsistencia", oDm.ConsultaSQL(sql)));
                rptListadoAsistencia.RefreshReport();
                this.rptListadoAsistencia.RefreshReport();
                chkTodos.Checked = false;
            }

        }

        private void frmReporteListadoAsistencia_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'datosReporteAsistencia.DTListadoAsistencia' Puede moverla o quitarla según sea necesario.
            //this.tableAdapterListadoAsistencia.Fill(this.datosReporteAsistencia.DTListadoAsistencia);
            //this.rptListadoAsistencia.RefreshReport();
            this.CenterToParent();
            this.cargarCombo(cboUsuarios, oUsuarioService.ObtenerTodos(), "NombreUsuario", "IdUsuario");
            this.cargarCombo(cboEstados, oEstadosAsistenciaService.ObtenerTodos(), "n_estados_asistencia", "id_estado_asistencia");
        }

        private void cargarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
