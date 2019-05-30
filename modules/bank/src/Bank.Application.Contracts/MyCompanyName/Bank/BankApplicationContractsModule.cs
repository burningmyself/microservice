using Microsoft.Extensions.DependencyInjection;
using Bank.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Bank
{
    [DependsOn(
        typeof(BankDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class BankApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BankApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BankResource>()
                    .AddVirtualJson("/MyCompanyName/Bank/Localization/ApplicationContracts");
            });
        }
    }
}
