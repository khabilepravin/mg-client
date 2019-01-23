using apiProxy.impl;
using Autofac;

namespace apiProxy
{
    public static class Bootstrapper
    {
        public static void Bootstrap(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<MediaApi>().As<IMediaApi>();
            containerBuilder.RegisterType<SearchApi>().As<ISearchApi>();
        }
    }
}
