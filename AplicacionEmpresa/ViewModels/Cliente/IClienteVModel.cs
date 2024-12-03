using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEmpresa.Models;

namespace AplicacionEmpresa.ViewModels.Cliente
{
    public interface IClienteVModel
    {
        List<Models.Cliente> Clientes { get; set; }
    }
}
