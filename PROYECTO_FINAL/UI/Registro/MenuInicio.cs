using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.UI.Registro;


namespace ProyectoFinal
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void AbrirPanel(object Usuario)
        {
            if (this.central.Controls.Count > 0)
                this.central.Controls.RemoveAt(0);

            Form fh = Usuario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.central.Controls.Add(fh);
            this.central.Tag = fh;
            fh.Show();

        }
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Usuario());
        }

        //Guardar en la base de datos


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
