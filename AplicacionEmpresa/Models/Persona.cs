using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionEmpresa.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public int Edad { get; set; }
    }
}