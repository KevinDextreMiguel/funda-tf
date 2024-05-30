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
//enviar correo
using System.Net;
using System.Net.Mail;//esto
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Messaging;
using System.Net.Configuration;
//using System.Net.Mime;

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class frmRegistrarCliente : Form
    {
        const string Usuario = "dextremiguelk@gmail.com";
        const string Password = "tucontraseña";
        NegCliente objNegCliente = new NegCliente();
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            //validar solo para el ingreso de números
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEdad.Text, "^[0-9]"))
            {
                txtEdad.Text = "";
            }
        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {


        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" && txtPassword.Text != "")
            {
                Cliente objCliente = new Cliente();
                objCliente.Nombre = txtNombre.Text;
                objCliente.Apellido = txtApellido.Text;
                objCliente.Edad = Convert.ToInt32(txtEdad.Text);
                objCliente.Numero_telefono = txtTelefono.Text;
                objCliente.Correo_electronico = txtEmail.Text;
                objCliente.Contrasenia = txtPassword.Text;
                objCliente.Distrito = textBoxDistrito.Text;


                MessageBox.Show(objNegCliente.RegistrarCliente(objCliente));
            }
            else
            {
                MessageBox.Show("Rellenar todos los campos");
            }
        }
    }
}




