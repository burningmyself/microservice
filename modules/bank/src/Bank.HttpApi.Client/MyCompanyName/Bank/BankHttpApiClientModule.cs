using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Bank
{
    [DependsOn(
        typeof(BankApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BankHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Bank";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BankApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
