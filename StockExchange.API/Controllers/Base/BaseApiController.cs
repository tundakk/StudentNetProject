namespace StockExchange.API.Controllers.Base
{
    using System.Web.Http;

    public abstract class BaseApiController<T> : ApiController
         where T : BaseApiController<T>
    {
        protected readonly ILogger<T> Logger;

        public BaseApiController(ILogger<T> logger)
        {
            Logger = logger;
        }
    }
}
