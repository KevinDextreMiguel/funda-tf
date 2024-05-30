using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class AMiEstadoCompra : Form
    {
        Cliente cliente=new Cliente();
        NegPedido pedido=new NegPedido();   
        public AMiEstadoCompra(Cliente cl)
        {
            cliente = cl;
            InitializeComponent();
        }

        private void AMiEstadoCompra_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + cliente.Nombre + " Su estado es:";
            dataGridViewPedido.DataSource = pedido.Buscar(cliente.ID_cliente);
        }
    }
}
