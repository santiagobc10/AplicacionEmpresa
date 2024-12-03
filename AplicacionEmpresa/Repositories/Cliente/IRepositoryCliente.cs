using AplicacionEmpresa.Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEmpresa.Repositories.Cliente
{
    public interface IRepositoryCliente : IRepositoryCore, ITSql<Models.Cliente>
    {
        Task<List<Models.Cliente>> GetClientes();
    }
}
