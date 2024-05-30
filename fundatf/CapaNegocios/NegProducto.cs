using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegProducto
    {
        DataProducto dataProducto=new DataProducto();
        public string Registrar(Producto objcleinte)
        {
           return dataProducto.Registrar(objcleinte);
        }
        public string Modificar(Producto objProducto)
        {
            return dataProducto.Modificar(objProducto);
        }
        public string Eliminar(int id)
        {
            return dataProducto.Eliminar(id);
        }
        public List<Producto> Listar()
        {
            return dataProducto.Listar();
        }
    }
}
