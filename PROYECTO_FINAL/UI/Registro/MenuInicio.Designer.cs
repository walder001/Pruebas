namespace ProyectoFinal
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btbConsulta = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.central = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnMantenimiento);
            this.panel1.Controls.Add(this.btbConsulta);
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 465);
            this.panel1.TabIndex = 0;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 255);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(230, 40);
            this.btnMantenimiento.TabIndex = 3;
            this.btnMantenimiento.Text = "       Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btbConsulta
            // 
            this.btbConsulta.FlatAppearance.BorderSize = 0;
            this.btbConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbConsulta.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbConsulta.ForeColor = System.Drawing.Color.White;
            this.btbConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btbConsulta.Image")));
            this.btbConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbConsulta.Location = new System.Drawing.Point(0, 176);
            this.btbConsulta.Name = "btbConsulta";
            this.btbConsulta.Size = new System.Drawing.Size(230, 40);
            this.btbConsulta.TabIndex = 2;
            this.btbConsulta.Text = "Consulta";
            this.btbConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(1, 94);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(230, 40);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // central
            // 
            this.central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.central.Location = new System.Drawing.Point(230, 0);
            this.central.Name = "central";
            this.central.Size = new System.Drawing.Size(601, 465);
            this.central.TabIndex = 0;
            this.central.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 465);
            this.Controls.Add(this.central);
            this.Controls.Add(this.panel1);
            this.Name = "MenuInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btbConsulta;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel central;
    }
}

