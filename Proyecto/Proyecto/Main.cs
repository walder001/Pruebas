using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if(Lateral.Width == 250)
			{
				Lateral.Width = 70;
			}
			else
			{
				Lateral.Width = 250;
			}
		}

		private void btnVenta_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void Lateral_Paint(object sender, PaintEventArgs e)
		{

		}
		private void AbrirPanel(object Formhijo)
		{
			if (this.central.Controls.Count > 0)
				this.central.Controls.RemoveAt(0);

			Form fh = Formhijo as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.central.Controls.Add(fh);
			this.central.Tag = fh;
			fh.Show();

		}

		private void btnProducto_Click(object sender, EventArgs e)
		{
			AbrirPanel(new Productos());

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			btnMin.Visible = true;
			btnMax.Visible = false;
		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimiixar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			btnMax.Visible = true;
			btnMin.Visible = false;
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			Close();
			AbrirPanel(new Main());
		}
	}
}
