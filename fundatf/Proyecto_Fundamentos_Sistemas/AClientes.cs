using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//para graficar
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;
using CapaDatos;

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class AClientes : Form
    {
        NegCliente negCliente = new NegCliente();
        NegDetallePedido detallePedido = new NegDetallePedido();
        NegProducto negProducto = new NegProducto();
        public AClientes()
        {
            InitializeComponent();
            comboBoxApellido.Visible = false;
        }

        private void AClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negCliente.Listar();
            chartBarras.Visible = false;
            dataGridView1.Visible = false;

            dataGridView1.Columns["ID_cliente"].Visible = false;
            dataGridView1.Columns["Pedidoes"].Visible = false;

            // dataGridView1.Visible=false;
            //chartBarras.Visible=false;
        }

        private void Barras()
        {
            dataGridView1.Visible = false;
            chartBarras.Visible = true;
            // chartBarras.Visible = false;
            //limpiar
            //chartBarras.ResetAutoValues();
            chartBarras.Series.Clear();
            chartBarras.Titles.Clear();

            

            chartBarras.ChartAreas[0].Area3DStyle.Enable3D = false;
            //vectores
            int n1 = negCliente.CantidadPorUnDistrito("Huachipa");
            int n2 = negCliente.CantidadPorUnDistrito("Pueblo Libre");
            int n3 = negCliente.CantidadPorUnDistrito("Breña");
            int n4 = negCliente.CantidadPorUnDistrito("Puente Piedra");
            string[] series = { "Huachipa", "Pueblo Libre", "Breña", "Puente Piedra" };
            int[] puntos = { n1, n2, n3, n4 };

            //color
            chartBarras.Palette = ChartColorPalette.Pastel;
            //titulo
            chartBarras.Titles.Add("Cantidad según distrito");
            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chartBarras.Series.Add(series[i]);
                //cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
        //Huachipa
        //Pueblo Libre
        //Breña
        //Puente Piedra
        private void Circular()
        {
            dataGridView1.Visible = false;
            // chartBarras.Visible = false;
            chartBarras.Visible = true;
            //limpiar
            //chartBarras.ResetAutoValues();
            chartBarras.Series.Clear();
            chartBarras.Titles.Clear();
            chartBarras.Legends.Clear();



            //vectores

            double n1 = FiltrarPorProducto("1 pollo");
            double n2=FiltrarPorProducto("1/2 pollo");
            double n3=FiltrarPorProducto("1/4 de pollo");
            double n4=FiltrarPorProducto("1/8 de pollo");
            string[] sectores = { "1 pollo", "1/2 pollo", "1/4 de pollo", "1/8 de pollo" };
            

            n1=Math.Round(n1,2);
            n2=Math.Round(n2,2);
            n3=Math.Round(n3,2);
            n4=Math.Round(n4,2);

            double[] valores = { n1, n2, n3, n4 };
            //titulo Principal
            var titulo = new Title();
            titulo.Font = new Font("Elephant", 22, FontStyle.Bold);
            titulo.ForeColor = Color.DarkBlue;
            titulo.Text = "Distribución de Venta";
            //titulo
            chartBarras.Titles.Add(titulo);

            //titulo secundario
            var titulo2 = new Title();
            titulo2.Font = new Font("Arial", 18, FontStyle.Bold);
            titulo2.ForeColor = Color.DarkRed;
            titulo2.Text = "Valores en porcentaje";
            //titulo
            chartBarras.Titles.Add(titulo2);

            //Insertar leyenda
            chartBarras.Legends.Add("Leyenda");
            chartBarras.Legends[0].Title = "Platos";

            //color
            chartBarras.Palette = ChartColorPalette.SemiTransparent;

            chartBarras.Series.Add("Ventas");
            chartBarras.Series[0].ChartType = SeriesChartType.Pie;

            //mostrar valores
            chartBarras.Series[0].IsValueShownAsLabel = true;

            //Inclinación del gráfico
            chartBarras.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartBarras.ChartAreas[0].Area3DStyle.Inclination = 30;
            chartBarras.ChartAreas[0].Area3DStyle.Rotation = 60;

            chartBarras.Series[0].Points.DataBindXY(sectores, valores);

        }

        public void PorInicialApellido(string inicialApellido)
        {

            chartBarras.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = negCliente.ClientesPorInicialApellido(inicialApellido);

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPagarProductos_Click(object sender, EventArgs e)
        {
            if (comboBoxElegir.Text == "Clientes por Distrito")//Barras
                Barras();
            else if (comboBoxElegir.Text == "Distribución de Venta")//Gráfico
                Circular();
            else
            {
                //comboBoxApellido.Visible = true;
                PorInicialApellido(comboBoxApellido.Text);
            }
        }

        private void comboBoxElegir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxElegir.SelectedIndex == 0 || comboBoxElegir.SelectedIndex == 1)
                comboBoxApellido.Visible = false;
            else
                comboBoxApellido.Visible = true;

        }

        double FiltrarPorProducto(string nombreProducto)
        {
            double total = 0;
            foreach (var item in detallePedido.Listar())
            {
                foreach (var item1 in negProducto.Listar())
                {
                    if(item.ID_Producto==item1.ID_Producto && item1.Nombre_producto==nombreProducto)
                    {
                        total++;
                    }
                }
            }
            return (total/ detallePedido.Listar().Count)*100;
        }

        private void chartBarras_Click(object sender, EventArgs e)
        {

        }
    }
}
