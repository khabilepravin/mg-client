using apiProxy.proxyGeneratedCode.API;
using Autofac;

namespace apiProxy
{
    public static class Bootstrapper
    {
        public static void Bootstrap(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<MediaApi>().As<IMediaApi>();
            containerBuilder.RegisterType<MediaArtistApi>().As<IMediaArtistApi>();
            containerBuilder.RegisterType<ParsedTextArtistApi>().As<IParsedTextArtistApi>();
            containerBuilder.RegisterType<SearchApi>().As<ISearchApi>();
            containerBuilder.RegisterType<TagApi>().As<ITagApi>();
            containerBuilder.RegisterType<TextApi>().As<ITextApi>();
            containerBuilder.RegisterType<UserCollectionApi>().As<IUserCollectionApi>();
            containerBuilder.RegisterType<UserFavoriteApi>().As<IUserFavoriteApi>();
        }
    }
}
