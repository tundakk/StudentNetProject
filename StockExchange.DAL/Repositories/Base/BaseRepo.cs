namespace StockExchange.DAL.Repositories.Base
{
    using Microsoft.Extensions.Logging;
    using StockExchange.DAL.DataModel;

    public abstract class BaseRepo<T> : IBaseRepo<T> where T : class, new()
    {
        public readonly ILogger<T> logger;
        public readonly IDbContext deliveryContext;

        public BaseRepo(ILogger<T> logger, IDbContext deliveryContext)
        {
            this.logger = logger;
            this.deliveryContext = deliveryContext;
        }
    }
}
