using CapaDatos;
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
/*
 
  public int ID_Producto { get; set; }
        public string Nombre_producto { get; set; }
        public double Precio_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public int Categorias_Productos_ID_Categoria { get; set; }
 */
namespace Proyecto_Fundamentos_Sistemas
{
    public partial class ARegistrarProducto : Form
    {
        NegProducto negProducto=new NegProducto();
        public ARegistrarProducto()
        {
            InitializeComponent();
        }
        void Actualizar()
        {
            textBoxCategoria.Text = "";
            textBoxDescripcion.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxNombre.Focus();
            dataGridViewProductos.DataSource = negProducto.Listar();
            dataGridViewProductos.Columns["ID_Producto"].Visible = false;
            dataGridViewProductos.Columns["Categorias_Productos_ID_Categoria"].Visible = false;
           dataGridViewProductos.Columns["ProductoxProveedors"].Visible = false;
            dataGridViewProductos.Columns["Detalle_Pedido"].Visible = false;
        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (textBoxCategoria.Text == "" || textBoxDescripcion.Text == "" || textBoxNombre.Text == "" || textBoxPrecio.Text=="")
                MessageBox.Show("Es necesario todos los campos");
            else{
                Producto p=new Producto();
                p.Nombre_producto=textBoxNombre.Text;
                p.Precio_producto=float.Parse(textBoxPrecio.Text);
                p.Descripcion_producto=textBoxDescripcion.Text;

                MessageBox.Show(negProducto.Registrar(p));
                Actualizar();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ARegistrarProducto_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Producto p = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
            MessageBox.Show(negProducto.Eliminar(p.ID_Producto));
            Actualizar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxCategoria.Text == "" || textBoxDescripcion.Text == "" || textBoxNombre.Text == "" || textBoxPrecio.Text == "")
                MessageBox.Show("Es necesario todos los campos");
            else
            {
                Producto p1 = new Producto();
                Producto p = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
                // Producto p = new Producto();
                p1.ID_Producto = p.ID_Producto;
                p1.Nombre_producto = textBoxNombre.Text;
                p1.Precio_producto = float.Parse(textBoxPrecio.Text);
                p1.Descripcion_producto = textBoxDescripcion.Text;
                //p. = textBoxCategoria.Text;

                MessageBox.Show(negProducto.Modificar(p1));
                Actualizar();
            }
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrecio.Text, "^[0-9]"))
            {
                textBoxPrecio.Text = "";
            }
        }
    }
}
