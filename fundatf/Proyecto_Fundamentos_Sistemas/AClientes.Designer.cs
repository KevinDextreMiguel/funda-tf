namespace Proyecto_Fundamentos_Sistemas
{
    partial class AClientes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AClientes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxElegir = new System.Windows.Forms.ComboBox();
            this.btnPagarProductos = new System.Windows.Forms.Button();
            this.comboBoxApellido = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartBarras
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBarras.Legends.Add(legend1);
            this.chartBarras.Location = new System.Drawing.Point(12, 12);
            this.chartBarras.Name = "chartBarras";
            this.chartBarras.Size = new System.Drawing.Size(649, 488);
            this.chartBarras.TabIndex = 1;
            this.chartBarras.Text = "chart1";
            this.chartBarras.Click += new System.EventHandler(this.chartBarras_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(760, 534);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(109, 40);
            this.buttonSalir.TabIndex = 57;
            this.buttonSalir.Text = "Volver";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(679, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Elige el tipo de reporte";
            // 
            // comboBoxElegir
            // 
            this.comboBoxElegir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxElegir.Items.AddRange(new object[] {
            "Clientes por Distrito",
            "Distribución de Venta",
            "Inicial Apellido"});
            this.comboBoxElegir.Location = new System.Drawing.Point(705, 39);
            this.comboBoxElegir.Name = "comboBoxElegir";
            this.comboBoxElegir.Size = new System.Drawing.Size(164, 28);
            this.comboBoxElegir.Sorted = true;
            this.comboBoxElegir.TabIndex = 59;
            this.comboBoxElegir.UseWaitCursor = true;
            this.comboBoxElegir.SelectedIndexChanged += new System.EventHandler(this.comboBoxElegir_SelectedIndexChanged);
            // 
            // btnPagarProductos
            // 
            this.btnPagarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPagarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarProductos.Location = new System.Drawing.Point(752, 106);
            this.btnPagarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarProductos.Name = "btnPagarProductos";
            this.btnPagarProductos.Size = new System.Drawing.Size(106, 35);
            this.btnPagarProductos.TabIndex = 60;
            this.btnPagarProductos.Text = "Visualizar";
            this.btnPagarProductos.UseVisualStyleBackColor = false;
            this.btnPagarProductos.Click += new System.EventHandler(this.btnPagarProductos_Click);
            // 
            // comboBoxApellido
            // 
            this.comboBoxApellido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxApellido.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxApellido.Location = new System.Drawing.Point(705, 73);
            this.comboBoxApellido.Name = "comboBoxApellido";
            this.comboBoxApellido.Size = new System.Drawing.Size(167, 28);
            this.comboBoxApellido.Sorted = true;
            this.comboBoxApellido.TabIndex = 61;
            this.comboBoxApellido.UseWaitCursor = true;
            // 
            // AClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(891, 585);
            this.Controls.Add(this.comboBoxApellido);
            this.Controls.Add(this.btnPagarProductos);
            this.Controls.Add(this.comboBoxElegir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.chartBarras);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AClientes";
            this.Text = "AClientes";
            this.Load += new System.EventHandler(this.AClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxElegir;
        private System.Windows.Forms.Button btnPagarProductos;
        private System.Windows.Forms.ComboBox comboBoxApellido;
    }
}