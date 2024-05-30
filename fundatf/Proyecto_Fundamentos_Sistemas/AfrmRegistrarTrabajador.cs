using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class AfrmRegistrarTrabajador : Form
    {
        NegEmpleado negEmpleado = new NegEmpleado();
        public AfrmRegistrarTrabajador()
        {
            InitializeComponent();
        }
        void Actualizar()
        {
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtPassword.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
            dataGridViewEmpleados.DataSource= negEmpleado.Listar();
            dataGridViewEmpleados.Columns["Id_del_Empleado"].Visible = false;
            dataGridViewEmpleados.Columns["PagoEmpleadoes"].Visible = false;
            dataGridViewEmpleados.Columns["Pedidoes"].Visible = false;
        }
        Empleado IngresarEmpleado()
        {
            Empleado empl = new Empleado();
            empl.Apellido = txtApellido.Text;
            empl.Email = txtEmail.Text;
            empl.Nombre = txtNombre.Text;
            empl.Contrasenia = txtPassword.Text;
            empl.Telefono = txtTelefono.Text;
            return empl;
        }

        private void AfrmRegistrarTrabajador_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Empleado p = dataGridViewEmpleados.CurrentRow.DataBoundItem as Empleado;
            Empleado eml = IngresarEmpleado();
            eml.ID_del_Empleado = p.ID_del_Empleado;
            MessageBox.Show(negEmpleado.Modificar(eml));
            Actualizar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewEmpleados.Rows[0].Cells[0].Value.ToString());

            MessageBox.Show(negEmpleado.Eliminar(id));
            Actualizar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtEmail.Text == "" || txtNombre.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "")
                MessageBox.Show("Todos los campos son necesarios");
            else
            {
                Empleado eml = IngresarEmpleado();
                MessageBox.Show(negEmpleado.Registrar(eml));
            }
            Actualizar();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            Empleado p = dataGridViewEmpleados.CurrentRow.DataBoundItem as Empleado;
            MessageBox.Show(negEmpleado.Eliminar(p.ID_del_Empleado));
            Actualizar();
        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtEmail.Text == "" || txtNombre.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "")
                MessageBox.Show("Todos los campos son necesarios");
            else
            {
                Empleado p = dataGridViewEmpleados.CurrentRow.DataBoundItem as Empleado;
                Empleado eml = IngresarEmpleado();
                eml.ID_del_Empleado = p.ID_del_Empleado;
                MessageBox.Show(negEmpleado.Modificar(eml));
            }
            Actualizar();
        }
    }
}
