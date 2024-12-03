using AplicacionEmpresa.Repositories.Cliente;
using AplicacionEmpresa.Repositories.Core;
using AplicacionEmpresa.ViewModels.Cliente;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AplicacionEmpresa
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //Repositories
            container.RegisterType<IRepositoryCore, RepositoryCore>();
            container.RegisterType<IRepositoryCliente, RepositoryCliente>();

            //ViewModels
            container.RegisterType<IClienteVModel, ClienteVModel>();

            //Resolve Dependency
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}