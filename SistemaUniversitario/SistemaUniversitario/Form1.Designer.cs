namespace SistemaUniversitario
{
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Usuario = new System.Windows.Forms.TextBox();
			this.Contraseña = new System.Windows.Forms.TextBox();
			this.btnAcceder = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 291);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.panel2.Controls.Add(this.Usuario);
			this.panel2.Controls.Add(this.Contraseña);
			this.panel2.Controls.Add(this.btnAcceder);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(250, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(484, 291);
			this.panel2.TabIndex = 1;
			this.panel2.UseWaitCursor = true;
			// 
			// Usuario
			// 
			this.Usuario.BackColor = System.Drawing.Color.Black;
			this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Usuario.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Usuario.ForeColor = System.Drawing.Color.White;
			this.Usuario.Location = new System.Drawing.Point(74, 59);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(284, 23);
			this.Usuario.TabIndex = 3;
			this.Usuario.Text = "Usuario";
			this.Usuario.UseWaitCursor = true;
			this.Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Contraseña
			// 
			this.Contraseña.BackColor = System.Drawing.Color.Black;
			this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Contraseña.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Contraseña.ForeColor = System.Drawing.Color.White;
			this.Contraseña.Location = new System.Drawing.Point(74, 116);
			this.Contraseña.Name = "Contraseña";
			this.Contraseña.Size = new System.Drawing.Size(284, 23);
			this.Contraseña.TabIndex = 4;
			this.Contraseña.Text = "Contraseña";
			this.Contraseña.UseWaitCursor = true;
			this.Contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// btnAcceder
			// 
			this.btnAcceder.Location = new System.Drawing.Point(104, 176);
			this.btnAcceder.Name = "btnAcceder";
			this.btnAcceder.Size = new System.Drawing.Size(87, 35);
			this.btnAcceder.TabIndex = 5;
			this.btnAcceder.Text = "Acceder";
			this.btnAcceder.UseVisualStyleBackColor = true;
			this.btnAcceder.UseWaitCursor = true;
			this.btnAcceder.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 291);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FmLogin";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox Usuario;
		private System.Windows.Forms.TextBox Contraseña;
		private System.Windows.Forms.Button btnAcceder;
	}
}

