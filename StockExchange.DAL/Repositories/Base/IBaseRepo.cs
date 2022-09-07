﻿namespace StockExchange.DAL.Repositories.Base
{
    using System.Linq.Expressions;

    public interface IBaseRepo<T> where T : class
    {
        IQueryable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();

        //Explicit Load support
        void Include(T entity, params Expression<Func<T, object>>[] joinedEntities);
        void IncludeCollection(T entity, params Expression<Func<T, ICollection<object>>>[] joinedEntities);
        IQueryable<T2> GetIncludeQuery<T2>(T entity, Expression<Func<T, T2>> join) where T2 : class;
        IQueryable<T2> GetIncludeCollectionQuery<T2>(T entity, Expression<Func<T, ICollection<T2>>> join) where T2 : class;
    }
}
