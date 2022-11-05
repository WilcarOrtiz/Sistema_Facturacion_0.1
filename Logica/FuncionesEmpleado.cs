using Datos;
using Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesEmpleado : IServiciosPersona<Empleado>
    {
        List<Empleado> empleados; 
        RepositorioEmpleados repositorioEmpleados = new RepositorioEmpleados();

        public FuncionesEmpleado()
        {
            empleados = new List<Empleado>();
            empleados = repositorioEmpleados.GetAll();
        }
        public string Agregar(Empleado persona)
        {
            String Mensaje;
            try
            {
                 empleados.Add(persona);
                 Mensaje = repositorioEmpleados.GuardarEmpleado(persona);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(Empleado persona)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Empleado persona)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAllUsuarios()
        {
            return repositorioEmpleados.GetAll();
        }
    }
}
