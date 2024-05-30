namespace Proyecto_Fundamentos_Sistemas
{
    partial class AGestionAdministrativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGestionAdministrativa));
            this.buttonColaborador = new System.Windows.Forms.Button();
            this.buttonProducto = new System.Windows.Forms.Button();
            this.buttonEstadistica = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColaborador
            // 
            this.buttonColaborador.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonColaborador.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColaborador.ForeColor = System.Drawing.Color.White;
            this.buttonColaborador.Location = new System.Drawing.Point(316, 142);
            this.buttonColaborador.Name = "buttonColaborador";
            this.buttonColaborador.Size = new System.Drawing.Size(189, 106);
            this.buttonColaborador.TabIndex = 0;
            this.buttonColaborador.Text = "Gestionar colaboradores";
            this.buttonColaborador.UseVisualStyleBackColor = false;
            this.buttonColaborador.Click += new System.EventHandler(this.buttonColaborador_Click);
            // 
            // buttonProducto
            // 
            this.buttonProducto.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducto.ForeColor = System.Drawing.Color.White;
            this.buttonProducto.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducto.Image")));
            this.buttonProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProducto.Location = new System.Drawing.Point(316, 21);
            this.buttonProducto.Name = "buttonProducto";
            this.buttonProducto.Size = new System.Drawing.Size(189, 102);
            this.buttonProducto.TabIndex = 1;
            this.buttonProducto.Text = "Gestionar productos";
            this.buttonProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducto.UseVisualStyleBackColor = false;
            this.buttonProducto.Click += new System.EventHandler(this.buttonProducto_Click);
            // 
            // buttonEstadistica
            // 
            this.buttonEstadistica.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonEstadistica.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadistica.ForeColor = System.Drawing.Color.White;
            this.buttonEstadistica.Image = ((System.Drawing.Image)(resources.GetObject("buttonEstadistica.Image")));
            this.buttonEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEstadistica.Location = new System.Drawing.Point(311, 267);
            this.buttonEstadistica.Name = "buttonEstadistica";
            this.buttonEstadistica.Size = new System.Drawing.Size(194, 94);
            this.buttonEstadistica.TabIndex = 2;
            this.buttonEstadistica.Text = "Estadísticas";
            this.buttonEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstadistica.UseVisualStyleBackColor = false;
            this.buttonEstadistica.Click += new System.EventHandler(this.buttonEstadistica_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(11, 380);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(109, 40);
            this.buttonSalir.TabIndex = 55;
            this.buttonSalir.Text = "Volver";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // AGestionAdministrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(522, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEstadistica);
            this.Controls.Add(this.buttonProducto);
            this.Controls.Add(this.buttonColaborador);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "AGestionAdministrativa";
            this.Text = "AGestionAdministrativa";
            this.Load += new System.EventHandler(this.AGestionAdministrativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonColaborador;
        private System.Windows.Forms.Button buttonProducto;
        private System.Windows.Forms.Button buttonEstadistica;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}