using Entitades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioUsuario : ArchivosPersona
    {
        public RepositorioUsuario() : base("Usuarios.txt")
        {
                
        }

        public List<Usuario>GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            List<Entitades.Usuario> usuarios = new List<Entitades.Usuario>();
            while (!sr.EndOfStream)
            {
                usuarios.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return usuarios;
        }

        Entitades.Usuario Mappear(String linea)
        {
            var Usuarios = new Entitades.Usuario();
            Usuarios.NombreUser = linea;
            Usuarios.Contraseña = linea;
            return Usuarios;
        }
    }
}
