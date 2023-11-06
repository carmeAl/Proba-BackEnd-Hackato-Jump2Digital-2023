using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIHackato.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}