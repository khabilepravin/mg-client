using Microsoft.Extensions.Options;

namespace apiProxy.impl
{
    public class ApiProxyBase
    {
        protected readonly ApiProxySetting _apiProxySetting;
        protected readonly string _baseUrl;
        public ApiProxyBase(IOptions<ApiProxySetting> options)
        {
            _apiProxySetting = options.Value;
            _baseUrl = options.Value.BaseUrl;
        }
    }
}
