using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegDetallePedido
    {
        DataDetallePedido dataDetallePedido=new DataDetallePedido();
        public string Registrar(Detalle_Pedido objcleinte)
        {
            return dataDetallePedido.Registrar(objcleinte);
        }
        public string Modificar(Detalle_Pedido objDetalle_Pedido)
        {
            return dataDetallePedido.Modificar(objDetalle_Pedido);
        }
        public string Eliminar(int id)
        {
            return dataDetallePedido.Eliminar(id);
        }
        public List<Detalle_Pedido> Listar()
        {
            return dataDetallePedido.Listar();
        }

        public Detalle_Pedido ExisteDetalle_Pedido(int id)
        {
            return dataDetallePedido.ExisteDetalle_Pedido(id);
        }
    }
}
