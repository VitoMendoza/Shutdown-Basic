using System;
using System.Linq;
using System.Windows.Forms;

namespace ShutdownBasic
{
    public partial class Principal : Form
    {
        ProcesoBase procesobase;
        public Principal()
        {
            procesobase = new ProcesoBase();
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            //cbxAccion.Items.Insert(0, "Apagar");
            //cbxAccion.Items.Insert(1, "Reiniciar");
            //cbxAccion.Items.Insert(2, "Cerrar Sesion");
            cbxAccion.SelectedItem = "Apagar";
        }
        private void ejecutarComando()
        {
            btnApagar.Enabled = false;
            string stringTiempo = txtTiempo.Text.Trim();
            if (stringTiempo != "" && stringTiempo != "0" && stringTiempo != "0,0")
            {
                double tiempo = double.Parse(stringTiempo);
                var accion = cbxAccion.Text.Trim();
                switch (accion)
                {
                    case "Apagar":
                        procesobase.apagarSistema(tiempo);
                        cbxAccion.SelectedValue = cbxAccion.SelectedItem.ToString();
                        break;
                    case "Reiniciar":
                        procesobase.reiniciarSistema(tiempo);
                        cbxAccion.SelectedValue = cbxAccion.SelectedItem.ToString();
                        break;
                    //case "Cerrar Sesion":
                    //    procesobase.cerrarSesionSistema(tiempo);
                    //    break;
                    default:
                        break;
                }
            }
            else
            {
                const string message = "¿Estas seguro de apagar/reiniciar el sistema?";
                const string caption = "Advertencia";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the yes button was pressed ...
                if (result == DialogResult.Yes)
                {
                    // ejecutar accion del sistema.
                    var accion = cbxAccion.SelectedItem.ToString();
                    switch (accion)
                    {
                        case "Apagar":
                            procesobase.apagarSistema(0);
                            break;
                        case "Reiniciar":
                            procesobase.reiniciarSistema(0);
                            break;
                        //case "Cerrar Sesion":
                        //    procesobase.cerrarSesionSistema(0);
                        //    break;
                        default:
                            break;
                    }
                }
            }
            btnApagar.Enabled = true;
            cbxAccion.SelectedValue = 1;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ejecutarComando();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            procesobase.cancelarApagado();
        }

        private void txtTiempo_Enter(object sender, EventArgs e)
        {
            if (txtTiempo.Text.Trim()=="Tiempo")
            {
                txtTiempo.Text = "";
            }
           
        }

        private void txtTiempo_Leave(object sender, EventArgs e)
        {
            if (txtTiempo.Text.Trim() == "")
            {
                txtTiempo.Text = "0";
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTiempo.Text.Contains(','))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                       {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar ==',' || e.KeyChar == '\b')
                          {
                    e.Handled = false;
                }
            }
        }

        private void btnApagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ejecutarComando();
            }
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            procesobase.cancelarApagado();
        }

        private void cbxAccion_Leave(object sender, EventArgs e)
        {
            cbxAccion.Text = cbxAccion.Text.Trim();
            if (!(cbxAccion.Text.Trim() == "Apagar") && !(cbxAccion.Text.Trim() == "Reiniciar") )
            {
                cbxAccion.SelectedItem = "Apagar";
            }
        }

        private void lnkFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procesobase.abrirEnlace("https://www.facebook.com/don.vitomendoza/");
        }

        private void lnkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procesobase.abrirEnlace("https://www.linkedin.com/in/vitomendoza/");
        }

        private void lnkWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procesobase.abrirEnlace("http://www.vito-mendoza.com/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            procesobase.abrirEnlace("https://www.facebook.com/don.vitomendoza/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            procesobase.abrirEnlace("https://www.linkedin.com/in/vitomendoza/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            procesobase.abrirEnlace("http://www.vito-mendoza.com/");
        }
    }
}
