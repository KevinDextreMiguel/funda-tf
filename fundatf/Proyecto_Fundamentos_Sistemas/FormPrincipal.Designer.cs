namespace Proyecto_Fundamentos_Sistemas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonEmpleado1 = new System.Windows.Forms.Button();
            this.button1Administrador = new System.Windows.Forms.Button();
            this.buttonCliente1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxContasenia = new System.Windows.Forms.TextBox();
            this.labelLogueo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmpleado1
            // 
            this.buttonEmpleado1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmpleado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleado1.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmpleado1.Image")));
            this.buttonEmpleado1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmpleado1.Location = new System.Drawing.Point(366, 97);
            this.buttonEmpleado1.Name = "buttonEmpleado1";
            this.buttonEmpleado1.Size = new System.Drawing.Size(140, 45);
            this.buttonEmpleado1.TabIndex = 40;
            this.buttonEmpleado1.Text = "Empleado";
            this.buttonEmpleado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleado1.UseVisualStyleBackColor = false;
            this.buttonEmpleado1.Click += new System.EventHandler(this.buttonEmpleado1_Click);
            // 
            // button1Administrador
            // 
            this.button1Administrador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Administrador.Image = ((System.Drawing.Image)(resources.GetObject("button1Administrador.Image")));
            this.button1Administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1Administrador.Location = new System.Drawing.Point(366, 155);
            this.button1Administrador.Name = "button1Administrador";
            this.button1Administrador.Size = new System.Drawing.Size(140, 33);
            this.button1Administrador.TabIndex = 41;
            this.button1Administrador.Text = "Administrador";
            this.button1Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Administrador.UseVisualStyleBackColor = false;
            this.button1Administrador.Click += new System.EventHandler(this.button1Administrador_Click);
            // 
            // buttonCliente1
            // 
            this.buttonCliente1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCliente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente1.Image = ((System.Drawing.Image)(resources.GetObject("buttonCliente1.Image")));
            this.buttonCliente1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCliente1.Location = new System.Drawing.Point(366, 213);
            this.buttonCliente1.Name = "buttonCliente1";
            this.buttonCliente1.Size = new System.Drawing.Size(140, 41);
            this.buttonCliente1.TabIndex = 42;
            this.buttonCliente1.Text = "Cliente";
            this.buttonCliente1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCliente1.UseVisualStyleBackColor = false;
            this.buttonCliente1.Click += new System.EventHandler(this.buttonCliente1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(149, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "          Contraseña          ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // TextBoxContasenia
            // 
            this.TextBoxContasenia.BackColor = System.Drawing.Color.Black;
            this.TextBoxContasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContasenia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxContasenia.Location = new System.Drawing.Point(144, 184);
            this.TextBoxContasenia.Name = "TextBoxContasenia";
            this.TextBoxContasenia.PasswordChar = '•';
            this.TextBoxContasenia.Size = new System.Drawing.Size(174, 29);
            this.TextBoxContasenia.TabIndex = 44;
            this.TextBoxContasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLogueo1
            // 
            this.labelLogueo1.AutoSize = true;
            this.labelLogueo1.BackColor = System.Drawing.Color.White;
            this.labelLogueo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogueo1.ForeColor = System.Drawing.Color.Blue;
            this.labelLogueo1.Location = new System.Drawing.Point(340, 257);
            this.labelLogueo1.Name = "labelLogueo1";
            this.labelLogueo1.Size = new System.Drawing.Size(190, 22);
            this.labelLogueo1.TabIndex = 47;
            this.labelLogueo1.Text = "No tienes una cuenta?";
            this.labelLogueo1.Click += new System.EventHandler(this.labelLogueo1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(144, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.BackColor = System.Drawing.Color.Black;
            this.textBoxusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxusuario.Location = new System.Drawing.Point(144, 134);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(174, 29);
            this.textBoxusuario.TabIndex = 48;
            this.textBoxusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(11, 297);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(109, 40);
            this.buttonSalir.TabIndex = 55;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(539, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.labelLogueo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxContasenia);
            this.Controls.Add(this.buttonCliente1);
            this.Controls.Add(this.button1Administrador);
            this.Controls.Add(this.buttonEmpleado1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEmpleado1;
        private System.Windows.Forms.Button button1Administrador;
        private System.Windows.Forms.Button buttonCliente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxContasenia;
        private System.Windows.Forms.Label labelLogueo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}