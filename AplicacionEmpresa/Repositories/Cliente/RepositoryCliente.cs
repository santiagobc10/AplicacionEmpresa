using AplicacionEmpresa.EntityFramework;
using AplicacionEmpresa.Repositories.Core;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionEmpresa.Repositories.Cliente
{
    public class RepositoryCliente : RepositoryCore, IRepositoryCliente
    {
        /// <summary>
        /// Metodo encargado de obtener el listado de clientes
        /// </summary>
        /// <returns></returns>
        public async Task<List<Models.Cliente>> GetClientes()
        {
            return await this.GetAll<Dic_Clientes>().Select(x => new Models.Cliente()
            {
                Id = x.cli_idClientePk,
                Nombre = x.cli_nombre,
                Estado = x.cli_estado
            }).ToListAsync();
        }

        public Task<bool> CreateAsync(Models.Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(Models.Cliente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}