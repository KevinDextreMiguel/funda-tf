using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class AfrmPedidos : Form
    {
        NegProducto negProducto=new NegProducto();


        Cliente cliente=new Cliente();
        NegPedido negPedido=new NegPedido();
        NegDetallePedido negDetalle=new NegDetallePedido();

        List<Producto> ListaProducto=new List<Producto>();
        public AfrmPedidos(Cliente c)
        {
            InitializeComponent();
            cliente = c;
        }

        private void AfrmPedidos_Load(object sender, EventArgs e)
        {
            label3.Text ="Bienvenido: " +cliente.Nombre;
            dataGridViewProductos.DataSource = negProducto.Listar();
            dataGridViewProductos.Columns["Id_Producto"].Visible=false;
            dataGridViewProductos.Columns["Categorias_Productos_Id_Categoria"].Visible=false;
            dataGridViewProductos.Columns["Detalle_Pedido"].Visible=false;
            dataGridViewProductos.Columns["ProductoxProveedors"].Visible=false;

            //dataGridView1.DataSource = negPedido.Listar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Producto p = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
            ListaProducto.Add(p);
            dataGridViewPedido.DataSource = ListaProducto.ToList();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            Producto p = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
            ListaProducto.Remove(p);
            dataGridViewPedido.DataSource = ListaProducto.ToList();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            Producto producto=new Producto();
           // Detalle_Pedido detalle = new Detalle_Pedido();
            pedido.Fecha_de_pedido = DateTime.Now;
            pedido.Estado_pedido = "Pendiente";
            foreach(Producto p in ListaProducto.ToList())
                pedido.Total += p.Precio_producto;
            
            pedido.Cliente_ID_cliente = cliente.ID_cliente;
            MessageBox.Show(negPedido.Registrar(pedido));
            ListaProducto.Clear();
            dataGridViewPedido.DataSource = ListaProducto.ToList();
            //Producto p1 = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
            //Pedido pedi = dataGridViewProductos.CurrentRow.DataBoundItem as Pedido;
            //
            //
            //
            //detalle.ID_Producto=p1.ID_Producto;
            //detalle.ID_de_pedido= pedi.ID_de_pedido;
            //detalle.Total=pedido.Total;
            //detalle.Cantidad= 1;
            //MessageBox.Show(negDetalle.Registrar(detalle));
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AMiEstadoCompra form=new AMiEstadoCompra(cliente);
            form.ShowDialog();
        }

        /*
 public int ID_de_pedido { get; set; }
        public System.DateTime Fecha_de_pedido { get; set; }
        public string Estado_pedido { get; set; }
        public int Cliente_ID_cliente { get; set; }
        public int Pedido_ID_del_Pedido { get; set; }
        public decimal Total { get; set; }
 */
    }
}






