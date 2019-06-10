namespace Proyecto
{
	partial class Productos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardarProducto = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(333, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnGuardarProducto
			// 
			this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarProducto.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
			this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
			this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarProducto.Location = new System.Drawing.Point(283, 416);
			this.btnGuardarProducto.Name = "btnGuardarProducto";
			this.btnGuardarProducto.Size = new System.Drawing.Size(265, 48);
			this.btnGuardarProducto.TabIndex = 1;
			this.btnGuardarProducto.Text = "Guardar";
			this.btnGuardarProducto.UseVisualStyleBackColor = false;
			// 
			// Productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 515);
			this.Controls.Add(this.btnGuardarProducto);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Productos";
			this.Text = "Productos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuardarProducto;
	}
}