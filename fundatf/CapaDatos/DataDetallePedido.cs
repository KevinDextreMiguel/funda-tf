using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 public int ID_de_pedido { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }
 
 
 */
namespace CapaDatos
{
    public class DataDetallePedido
    {
        public string Registrar(Detalle_Pedido objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Detalle_Pedidos.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registró exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(Detalle_Pedido objDetalle_Pedido)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.Detalle_Pedidos.Find(objDetalle_Pedido.ID_Producto);
                    modificado.ID_Producto = objDetalle_Pedido.ID_Producto;
                    modificado.ID_de_pedido = objDetalle_Pedido.ID_de_pedido;
                    modificado.Cantidad = objDetalle_Pedido.Cantidad;
                    modificado.Total = objDetalle_Pedido.Total;
                    contexto.SaveChanges();
                    return "Se modificó correctamente";
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
                    contexto.Detalle_Pedidos.Remove(contexto.Detalle_Pedidos.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Detalle_Pedido> Listar()
        {
            var contexto = new TFEntities();
            return contexto.Detalle_Pedidos.ToList<Detalle_Pedido>();
        }

        public Detalle_Pedido ExisteDetalle_Pedido(int id)
        {
            Detalle_Pedido Detalle_Pedido = null;
            foreach (Detalle_Pedido Detalle_Pedido1 in Listar())
                if (Detalle_Pedido1.ID_de_pedido == id)
                    Detalle_Pedido = Detalle_Pedido1;

            return Detalle_Pedido;
        }
    }
}
