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

namespace Proyecto_Fundamentos_Sistemas
{
    public partial class FormPrincipal : Form
    {
        NegCliente cliente = new NegCliente();
        NegEmpleado negEmpleado = new NegEmpleado();
       // static bool mailSent = false;
        string admin = "admin";
        string contra = "1234";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            textBoxusuario.Text = ""; TextBoxContasenia.Text = ""; textBoxusuario.Focus();
            label1.Visible = true; label2.Visible = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Visible = false;
            TextBoxContasenia.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxusuario.Select();
        }

        private void buttonEmpleado1_Click(object sender, EventArgs e)
        {
            if (textBoxusuario.Text == "" || TextBoxContasenia.Text == "") MessageBox.Show("Faltan campos");
            else
            {
                Empleado empleado = negEmpleado.ExisteEmpleado(textBoxusuario.Text,TextBoxContasenia.Text);
                Limpiar();
                if (empleado != null)
                {
                    ATrabajador form = new ATrabajador(empleado);
                    form.ShowDialog();
                }
                else MessageBox.Show("Credenciales incorrectos");
            }
        }

        private void button1Administrador_Click(object sender, EventArgs e)
        {
            if (TextBoxContasenia.Text == contra && textBoxusuario.Text == admin)
            {
                Limpiar();
                AGestionAdministrativa aGestionAdministrativa = new AGestionAdministrativa();
                aGestionAdministrativa.ShowDialog();
            }
            else MessageBox.Show("Datos incorrectos");
        }

        private void buttonCliente1_Click(object sender, EventArgs e)
        {
            if (textBoxusuario.Text == "" || TextBoxContasenia.Text == "") MessageBox.Show("Faltan campos");
            else
            {
                Cliente client = cliente.ExisteCliente(textBoxusuario.Text, TextBoxContasenia.Text);
                Limpiar();
                if (client != null)
                {
                    AfrmPedidos form = new AfrmPedidos(client);
                    form.ShowDialog();
                }
                else MessageBox.Show("Credenciales incorrectos");
            }
        }

        private void labelLogueo1_Click(object sender, EventArgs e)
        {
            Limpiar();
            frmRegistrarCliente frm = new frmRegistrarCliente();
            frm.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
