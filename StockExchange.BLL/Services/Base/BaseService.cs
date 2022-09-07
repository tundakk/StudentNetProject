namespace StockExchange.BLL.Services.Base
{
    using Microsoft.Extensions.Logging;

    public abstract class BaseService<T> : IBaseService<T> where T : class, new()
    {
        protected readonly ILogger<T> Logger;

        public BaseService(ILogger<T> logger)
        {
            Logger = logger;
        }
    }
}
