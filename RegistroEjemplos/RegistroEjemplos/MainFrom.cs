using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEjemplos
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void Limpiar()
        {
            IDdomainUpDown1.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            DateTime1.Value = DateTime.Now;
            /// MyErrorProvider.Clear();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            RegistroEjemplos.UI.Registros.Registro reg = new RegistroEjemplos.UI.Registros.Registro();
            reg.Show();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void IDdomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void DateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
