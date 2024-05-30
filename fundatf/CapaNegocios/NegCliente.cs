using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegCliente
    {
        DataCliente objDataCliente= new DataCliente();
        public string RegistrarCliente(Cliente objcliente)
        {
            return objDataCliente.Registrar(objcliente);
        }
        public string Modificar(Cliente objcliente)
        {
            return objDataCliente.Modificar(objcliente);
        }
        public string Eliminar(int id)
        {
            return objDataCliente.Eliminar(id);
        }
        public List<Cliente> Listar()
        {
            return objDataCliente.Listar();
        }
        public Cliente ExisteCliente(string nombre, string contra)
        {
            return objDataCliente.ExisteCliente(nombre, contra);
        }
        public List<Cliente> ClientesPorInicialApellido(string InicialApellido)
        {
            return objDataCliente.ClientesPorInicialApellido(InicialApellido);
        }
        public int CantidadPorUnDistrito(string distriro)
        {
            return objDataCliente.CantidadPorUnDistrito(distriro);
        }
    }
}
