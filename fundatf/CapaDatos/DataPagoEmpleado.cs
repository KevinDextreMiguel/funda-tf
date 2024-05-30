using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  public int ID_PagoEmpleado { get; set; }
        public System.DateTime fecha { get; set; }
        public double PagoHora { get; set; }
        public int CantHora { get; set; }
        public string TipoPago { get; set; }
        public double Total { get; set; }
 
 */
namespace CapaDatos
{
    public class DataPagoPagoEmpleado
    {
        public string Registrar(PagoEmpleado objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.PagoEmpleados.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registró exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(PagoEmpleado objPagoEmpleado)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.PagoEmpleados.Find(objPagoEmpleado.ID_Empleado);
                    modificado.ID_Empleado = objPagoEmpleado.ID_Empleado;
                    modificado.fecha= objPagoEmpleado.fecha;
                    modificado.PagoHora = objPagoEmpleado.PagoHora;
                    modificado.CantHora = objPagoEmpleado.CantHora;
                    modificado.TipoPago = objPagoEmpleado.TipoPago;
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
                    contexto.PagoEmpleados.Remove(contexto.PagoEmpleados.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<PagoEmpleado> Listar()
        {
            var contexto = new TFEntities();
            return contexto.PagoEmpleados.ToList<PagoEmpleado>();
        }

        public PagoEmpleado ExistePagoEmpleado(int id)
        {
            PagoEmpleado PagoEmpleado = null;
            foreach (PagoEmpleado PagoEmpleado1 in Listar())
                if (PagoEmpleado1.ID_Empleado==id)
                    PagoEmpleado = PagoEmpleado1;

            return PagoEmpleado;
        }
    }
}
