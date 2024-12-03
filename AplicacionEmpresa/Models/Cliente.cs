using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionEmpresa.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}