﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitades
{
    public class Usuario : Empleado
    {
        public String NombreUser { get; set; }  
        public String Contraseña { get; set; }  
    }
}
