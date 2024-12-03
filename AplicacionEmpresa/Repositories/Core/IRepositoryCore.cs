using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEmpresa.Repositories.Core
{
    public interface IRepositoryCore
    {
        //Metoeo encargado de consultar todo los registros
        IQueryable<TEntity> AsQueryable<TEntity>() where TEntity : class;
        //Metoeo encargado de consultar todo los registros
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        //Metodo encargado de buscar registros segun la predicado
        IQueryable<TEntity> Search<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
    }

    public interface ITSql<TEntity> where TEntity : class
    {
        //Metodo encargado de crear un permiso
        Task<bool> CreateAsync(TEntity entity);
        //Metodo encargado de actualizar las columnas de un permiso
        Task<bool> UpdateAsync(TEntity entity);
        //Metodo encargado de eliminar un permiso
        Task<bool> DeleteAsync(int id);
    }

    /// <summary>
    /// Representa las excepciones con sus datos ya tratados
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// Propiedad que indica si existe un error
        /// </summary>
        bool IsError { get; set; }
        /// <summary>
        /// Propiedad que contiene la excepción generada
        /// </summary>
        Exception Exception { get; set; }
        /// <summary>
        /// Propiedad que contiene todo el mensaje del error junto con los InnerException
        /// </summary>
        string Message { get; set; }
    }
}
