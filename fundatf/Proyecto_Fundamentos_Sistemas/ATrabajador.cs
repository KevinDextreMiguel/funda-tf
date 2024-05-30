using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Fundamentos_Sistemas
{

    public partial class ATrabajador : Form
    {
        Empleado empleado = new Empleado();
        NegPagoEmpleado NegpagoEmpleado = new NegPagoEmpleado();
        public ATrabajador(Empleado e)
        {
            empleado = e;
            InitializeComponent();
        }

        private void ATrabajador_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido " + empleado.Nombre;
            PagoEmpleado pago = NegpagoEmpleado.ExistePagoEmpleado(empleado.ID_del_Empleado);
            if (pago != null) ;
            {
                label11.Text = pago.fecha.ToString();
                label12.Text = pago.PagoHora.ToString();
                label13.Text = pago.CantHora.ToString();
                label14.Text = pago.TipoPago;
                label15.Text = pago.Total.ToString();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         ID_Empleado	int
            fecha	date
            PagoHora	float
            CantHora	int
            TipoPago	varchar(50)
            Total	float
	
         
                 */
    }

}
