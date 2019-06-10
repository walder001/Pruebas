namespace EjemploRegistroFecha_27_05_2019
{
    partial class rEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.EdadnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Buscar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EdadnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(181, 117);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(244, 20);
            this.NombretextBox1.TabIndex = 2;
            // 
            // EdadnumericUpDown1
            // 
            this.EdadnumericUpDown1.Location = new System.Drawing.Point(181, 158);
            this.EdadnumericUpDown1.Name = "EdadnumericUpDown1";
            this.EdadnumericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.EdadnumericUpDown1.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(160, 242);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NombreId";
            // 
            // IdnumericUpDown2
            // 
            this.IdnumericUpDown2.Location = new System.Drawing.Point(181, 76);
            this.IdnumericUpDown2.Name = "IdnumericUpDown2";
            this.IdnumericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.IdnumericUpDown2.TabIndex = 6;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(276, 76);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(293, 242);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 8;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // rEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 312);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.IdnumericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.EdadnumericUpDown1);
            this.Controls.Add(this.NombretextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rEstudiante";
            this.Text = "rEstudiante";
            this.Load += new System.EventHandler(this.REstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EdadnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.NumericUpDown EdadnumericUpDown1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown2;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Modificar;
    }
}