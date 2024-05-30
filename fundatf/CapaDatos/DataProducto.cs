using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 public int ID_Producto { get; set; }
        public string Nombre_producto { get; set; }
        public double Precio_producto { get; set; }
        public string Descripción_producto { get; set; }
        public int Categorías_Productos_ID_Categoría { get; set; }
*/
namespace CapaDatos
{
    public class DataProducto
    {
        public string Registrar(Producto objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Productos.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registró exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(Producto objProducto)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.Productos.Find(objProducto.ID_Producto);
                    modificado.Nombre_producto = objProducto.Nombre_producto;
                    modificado.Precio_producto = objProducto.Precio_producto;
                    modificado.Descripcion_producto = objProducto.Descripcion_producto;
                    
                    contexto.SaveChanges();
                    return "Se modificó de forma exitoso";
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
                    contexto.Productos.Remove(contexto.Productos.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Producto> Listar()
        {
            var contexto = new TFEntities();
            return contexto.Productos.ToList<Producto>();
        }
    }
}
