using AplicacionEmpresa.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AplicacionEmpresa.Repositories.Core
{
    public abstract class RepositoryCore : IRepositoryCore, IDisposable
    {
        public DbContext DbContext { get; set; }

        protected readonly DataBaseEntities db;

        private bool disposedValue;

        public RepositoryCore()
        {
            this.db = new DataBaseEntities();
            this.DbContext = this.db;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //Metodo encargado de consultar todo los registros
        public virtual IQueryable<TEntity> AsQueryable<TEntity>() where TEntity : class
        {
            //Obtenemos todos los elementos de la base de datos
            return this.DbContext.Set<TEntity>().AsQueryable();
        }

        //Metodo encargado de consultar todo los registros
        public virtual IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            //Obtenemos todos los elementos de la base de datos
            return this.DbContext.Set<TEntity>();
        }

        //Metodo encargado de buscar registros segun la predicado
        public virtual IQueryable<TEntity> Search<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            //Buscamos en la base de datos la entidad que corresponda con el predicado
            return this.DbContext.Set<TEntity>().Where(predicate);
        }
    }
}