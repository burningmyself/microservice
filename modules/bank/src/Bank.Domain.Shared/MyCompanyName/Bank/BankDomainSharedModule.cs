using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Bank.Localization;

namespace Bank
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class BankDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<BankResource>("en");
            });
        }
    }
}
