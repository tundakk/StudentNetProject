namespace StockExchange.DAL.DataModel
{

    using System.Collections.Generic;
    using System.Data.Entity;

    public interface IDbContext

    {
        int BatchSaveChanges();
        void BulkSaveChanges();
        int SaveChanges();
        void BulkDelete<T>(IDbSet<T> dbSet, IEnumerable<T> entities) where T : class;
        void SetModified<TEntity>(TEntity entity) where TEntity : class;

        EntityState GetState<TEntity>(TEntity entity) where TEntity : class;
        void SetState<TEntity>(TEntity entity, EntityState state) where TEntity : class;

        DbSet<TestModel> TestModels { get; set; } //example class

    }
}