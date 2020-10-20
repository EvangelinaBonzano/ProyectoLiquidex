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
using ProyectoLiquidexSA.Entities;

namespace ProyectoLiquidexSA.GUILayer.Perfiles
{
    public partial class frmABMPerfil : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly PerfilService oPerfilService;
        private Perfil oPerfilSelected;

        public frmABMPerfil()
        {
            InitializeComponent();
            oPerfilService = new PerfilService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public enum FormMode
        {
            insert,
            //update,
            delete
        }

        private void frmABMPerfil_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Perfil";
                        txtNombre.Enabled = true;
                        txtSueldo.Enabled = true;
                        break;
                    }
                //case FormMode.update:
                //    {
                //        MostrarDatos();
                //        this.Text = "Actualizar Perfil";
                //        txtNombre.Enabled = true;
                //        break;
                //    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Borrar ";
                        txtNombre.Enabled = false;
                        txtSueldo.Enabled = false;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oPerfilSelected != null)
            {
                txtNombre.Text = oPerfilSelected.Nombre;
                //txtSueldo.Text = oSueldoPerfilHistorico.Sueldo;
            }
        }

        public void SeleccionarPerfil(FormMode op, Perfil perfilSelected)
        {
            formMode = op;
            oPerfilSelected = perfilSelected;
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;

            return true;
        }

        private bool ExistePerfil()
        {
            return oPerfilService.ObtenerPerfil(txtNombre.Text) != null;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (ExistePerfil() == false)
                        {

                            if (ValidarCampos())
                            {
                                var oPerfil = new Perfil();
                                oPerfil.Nombre = txtNombre.Text;
                                var oSueldoPerfilHistorico = new SueldoPerfilHistorico();

                                oSueldoPerfilHistorico.Sueldo = Convert.ToDouble(txtSueldo.Text);

                                if (oPerfilService.CrearPerfil(oPerfil, oSueldoPerfilHistorico))
                                {
                                    MessageBox.Show("Perfil insertado!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Sueldo Perfil Histórico insertado!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de perfil encontrado!!!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                //case FormMode.update:
                //    {
                //        if (ValidarCampos())
                //        {
                //            oPerfilSelected.Nombre = txtNombre.Text;

                //            if (oPerfilService.ActualizarPerfil(oPerfilSelected))
                //            {
                //                MessageBox.Show("Perfil actualizado!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                this.Dispose();
                //            }
                //            else
                //                MessageBox.Show("Error al actualizar el perfil!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }

                //        break;
                //    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea borrar el perfil seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oPerfilService.BorrarPerfil(oPerfilSelected))
                            {
                                MessageBox.Show("Perfil borrado con éxito!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar perfil!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

            if (txtSueldo.Text != null)
            {
                int sueldo = 0;
                int.TryParse(txtSueldo.Text, out sueldo);
            }
        }
        private void txtSueldo_Validating(object sender, CancelEventArgs e)
        {
            int numero;
            if (Int32.TryParse(txtSueldo.Text, out numero) && int.Parse(txtSueldo.Text) > 0)
            {
                txtSueldo_TextChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Debe ingresar una cantidad numérica positiva... ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSueldo.Text = "";
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
