using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIHackato.Models
{
    public class Skin
    {
        public int IdSkin { get; set; }
        public string NombreSkin { get; set; }
        public string Tipo { get; set; }
        public string Precio { get; set; }
        public string Color { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}