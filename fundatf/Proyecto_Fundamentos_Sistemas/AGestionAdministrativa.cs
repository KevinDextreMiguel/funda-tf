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
    public partial class AGestionAdministrativa : Form
    {
        NegCliente negCliente=new NegCliente();
        public AGestionAdministrativa()
        {
            InitializeComponent();
        }

        private void buttonColaborador_Click(object sender, EventArgs e)
        {
            AfrmRegistrarTrabajador frm=new AfrmRegistrarTrabajador();
            frm.ShowDialog();
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            ARegistrarProducto aRegistrarProducto = new ARegistrarProducto();
            aRegistrarProducto.ShowDialog();
        }

        private void buttonEstadistica_Click(object sender, EventArgs e)
        {
            AClientes aClientes = new AClientes();
            aClientes.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AGestionAdministrativa_Load(object sender, EventArgs e)
        {

        }
    }
}
