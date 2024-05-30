using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  public int ID_del_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Telefono { get; set; }
        public double Email { get; set; }
        public string Contraseña { get; set; }
 */
namespace CapaDatos
{
    public class DataEmpleado
    {
        public string Registrar(Empleado objcleinte)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    contexto.Empleados.Add(objcleinte);
                    contexto.SaveChanges();
                    return "Se registró exitosamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public string Modificar(Empleado objEmpleado)
        {
            try
            {
                using (var contexto = new TFEntities())
                {
                    var modificado = contexto.Empleados.Find(objEmpleado.ID_del_Empleado);
                    modificado.Nombre = objEmpleado.Nombre;
                    modificado.Apellido = objEmpleado.Apellido;
                    modificado.Telefono = objEmpleado.Telefono;
                    modificado.Email = objEmpleado.Email;
                    modificado.Contrasenia = objEmpleado.Contrasenia;
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
                    contexto.Empleados.Remove(contexto.Empleados.Find(id));
                    contexto.SaveChanges();
                    return "Se Eliminó correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public List<Empleado> Listar()
        {
            var contexto = new TFEntities();
            return contexto.Empleados.ToList<Empleado>();
        }

        public Empleado ExisteEmpleado(string nombre,string contra)
        {
            Empleado empleado = null;
            foreach(Empleado empleado1 in Listar())
                if(empleado1.Nombre == nombre && contra==empleado1.Contrasenia)
                    empleado=empleado1;

            return empleado;
        }
    }
}
