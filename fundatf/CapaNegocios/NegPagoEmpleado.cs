using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public  class NegPagoEmpleado
    {
        DataPagoPagoEmpleado dataPagoPagoEmpleado=new DataPagoPagoEmpleado();
        public string Registrar(PagoEmpleado objcleinte)
        {
            return dataPagoPagoEmpleado.Registrar(objcleinte);
        }
        public string Modificar(PagoEmpleado objPagoEmpleado)
        {
            return dataPagoPagoEmpleado.Modificar(objPagoEmpleado);
        }
        public string Eliminar(int id)
        {
            return dataPagoPagoEmpleado.Eliminar(id);
        }
        public List<PagoEmpleado> Listar()
        {
            return dataPagoPagoEmpleado.Listar();
        }

        public PagoEmpleado ExistePagoEmpleado(int id)
        {
            return dataPagoPagoEmpleado.ExistePagoEmpleado(id);
        }
    }
}
