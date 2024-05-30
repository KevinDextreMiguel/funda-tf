using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegPedido
    {
        DataPedido dataPedido=new DataPedido();
        public string Registrar(Pedido objcleinte)
        {
           return dataPedido.Registrar(objcleinte);

        }
        public string Modificar(Pedido objPedido)
        {
            return dataPedido.Modificar(objPedido);
        }
        public string Eliminar(int id)
        {
            return dataPedido.Eliminar(id);
        }
        public List<Pedido> Listar()
        {
            return dataPedido.Listar();
        }

        public Pedido ExistePedido(int id)
        {
            return dataPedido.ExistePedido(id);
        }
        public List<Pedido> Buscar(int id)
        {
            return dataPedido.Buscar(id);
        }
    }
}
