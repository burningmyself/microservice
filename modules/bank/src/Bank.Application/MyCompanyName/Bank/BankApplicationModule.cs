using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Bank
{
    [DependsOn(
        typeof(BankDomainModule),
        typeof(BankApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BankApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BankApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
