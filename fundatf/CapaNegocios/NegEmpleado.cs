using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegEmpleado
    {
        DataEmpleado dataEmpleado=new DataEmpleado();
        public string Registrar(Empleado objcleinte)
        {
            return dataEmpleado.Registrar(objcleinte);
        }
        public string Modificar(Empleado objEmpleado)
        {
            return dataEmpleado.Modificar(objEmpleado);
        }
        public string Eliminar(int id)
        {
            return dataEmpleado.Eliminar(id);
        }
        public List<Empleado> Listar()
        {
            return dataEmpleado.Listar();
        }
        public Empleado ExisteEmpleado(string nombre, string contra)
        {
            return dataEmpleado.ExisteEmpleado(nombre,contra);
        }
    }
}
