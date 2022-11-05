using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivosPersona
    {
        protected String ruta;

        public ArchivosPersona()
        {
            ruta = "Archivo.txt";
        }

        public ArchivosPersona(String FileName)
        {
            ruta= FileName;
        }

        public String GuardarEmpleado(Entitades.Empleado Persona)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Persona.ToString());
            sw.Close();
            return "Correcto";
        }

        public String GuardarClientes(Entitades.Cliente Persona)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Persona.ToString());
            sw.Close();
            return "Correcto";
        }

        public String GuardarUsuario(Entitades.Usuario Persona)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(Persona.ToString());
            sw.Close();
            return "Correcto";
        }

    }
}
