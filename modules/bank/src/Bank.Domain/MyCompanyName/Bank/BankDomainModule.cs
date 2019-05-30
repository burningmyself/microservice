using Microsoft.Extensions.DependencyInjection;
using Bank.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Bank
{
    [DependsOn(
        typeof(BankDomainSharedModule)
        )]
    public class BankDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<BankDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<BankResource>().AddVirtualJson("/MyCompanyName/Bank/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Bank", typeof(BankResource));
            });
        }
    }
}
