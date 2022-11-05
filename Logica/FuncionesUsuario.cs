﻿using Datos;
using Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FuncionesUsuario : IServiciosPersona<Usuario>
    {
        List<Usuario> usuarios;
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        public FuncionesUsuario()
        {
            usuarios = new List<Usuario>();
            usuarios = repositorioUsuario.GetAll();
        } 

        public string Agregar(Usuario persona)
        {
            String Mensaje;
            try
            {
                usuarios.Add(persona);
                Mensaje = repositorioUsuario.GuardarEmpleado(persona);
            }
            catch (Exception EX)
            {
                Mensaje = " " + EX;
            }
            return Mensaje;
        }

        public string Editar(Usuario persona)
        {
            throw new NotImplementedException();
        }     

        public string Eliminar(Usuario persona)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAllUsuarios()
        {
            return repositorioUsuario.GetAll();
        }

        public bool Login(String usuario , String contra)
        {
            foreach (Usuario item in GetAllUsuarios())
            {
                if (usuario==item.NombreUser & contra==item.Contraseña)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
