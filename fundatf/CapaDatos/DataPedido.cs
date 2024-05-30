using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 public int ID_de_pedido { get; set; }
        public System.DateTime Fecha_de_pedido { get; set; }
        public string Estado_pedido { get; set; }
        public int Cliente_ID_cliente { get; set; }
        public int Pedido_ID_del_Pedido { get; set; }
        public decimal Total { get; set; }
 */
namespace CapaDatos
{
    public class DataPedido
    {
        public string Registrar(Pedido objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Pedidos.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registró exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(Pedido objPedido)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.Pedidos.Find(objPedido.ID_de_pedido);
                    modificado.Fecha_de_pedido = objPedido.Fecha_de_pedido;
                    modificado.Estado_pedido = objPedido.Estado_pedido;
                    modificado.Total = objPedido.Total;

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
                    contexto.Pedidos.Remove(contexto.Pedidos.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Pedido> Listar()
        {
            var contexto = new TFEntities();
            return contexto.Pedidos.ToList<Pedido>();
        }

        public Pedido ExistePedido(int id)
        {
            Pedido Pedido = new Pedido();
            foreach (Pedido Pedido1 in Listar())
                if (Pedido1.ID_de_pedido == id)
                    Pedido = Pedido1;

            return Pedido;
        }

        public List<Pedido> Buscar(int id)
        {
            List < Pedido >lista=new List<Pedido> ();
            foreach (var pedido in Listar())
                if(pedido.Cliente_ID_cliente==id)
                    lista.Add(pedido);

            return lista;
        }   


    }
}
