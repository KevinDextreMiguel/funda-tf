using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataCliente
    {
        bool ordenar=true;
        public string Registrar(Cliente objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Clientes.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registro exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(Cliente objcliente)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.Clientes.Find(objcliente.ID_cliente);
                    modificado.Contrasenia = objcliente.Contrasenia;
                    contexto.SaveChanges();
                    return "Cambio de Contraseña exitoso";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public string Eliminar(int id)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Clientes.Remove(contexto.Clientes.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Cliente> Listar()
        {
            var contexto = new TFEntities();
            return contexto.Clientes.ToList<Cliente>();
        }

        public Cliente ExisteCliente(string nombre,string contra)
        {
            Cliente cliente=null;
            foreach (Cliente c in Listar())
                if (c.Nombre == nombre && c.Contrasenia == contra) cliente = c;
            return cliente;
        }

        public List<Cliente> ClientesPorInicialApellido(string InicialApellido)
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (Cliente c in Listar())
                if (InicialApellido[0] == c.Apellido[0])
                    clientes.Add(c);

            if (ordenar)
                clientes.OrderByDescending(c => c.Apellido);
            else
                clientes.OrderBy(c => c.Apellido);

            ordenar = false;

             return clientes;
        }

        public int CantidadPorUnDistrito(string distriro)
        {
            int t = 0;
            foreach (var c in Listar())
                if(c.Distrito == distriro) t++;

            return t;
        }
    }
}
