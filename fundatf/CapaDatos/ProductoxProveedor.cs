//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductoxProveedor
    {
        public int ID_del_Pedido_a_Proveedor { get; set; }
        public System.DateTime Fecha_pedido { get; set; }
        public System.DateTime Fecha_entrega { get; set; }
        public int Proveedor_ID_Proovedor { get; set; }
        public int Producto_ID_Producto { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}