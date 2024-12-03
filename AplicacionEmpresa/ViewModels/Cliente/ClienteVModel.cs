using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionEmpresa.ViewModels.Cliente
{
    public class ClienteVModel : IClienteVModel
    {
        public List<Models.Cliente> Clientes { get; set; }
    }
}