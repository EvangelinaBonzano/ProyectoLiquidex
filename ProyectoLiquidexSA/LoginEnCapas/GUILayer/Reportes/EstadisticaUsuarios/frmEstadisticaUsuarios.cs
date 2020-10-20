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

namespace ProyectoLiquidexSA.GUILayer.Reportes.EstadisticaUsuarios
{
    public partial class frmEstadisticaUsuarios : Form
    {
        public frmEstadisticaUsuarios()
        {
            InitializeComponent();
        }

        private void frmEstadisticaUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            DataManager oDm = new DataManager();
            oDm.Open();
            string sql = " SELECT p.nombre AS perfil, COUNT(u.id_usuario) as 'cantidad' " +
                        " FROM Usuarios u" +
                        " INNER JOIN Perfiles p ON(u.id_perfil = p.id_perfil)" +
                        " WHERE u.borrado = 0 " +
                        " GROUP BY p.nombre";

            rptEstadisticaUsuarios.LocalReport.DataSources.Clear();
            rptEstadisticaUsuarios.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticaUsuarios", oDm.ConsultaSQL(sql)));
            rptEstadisticaUsuarios.RefreshReport();
        }
    }
}
