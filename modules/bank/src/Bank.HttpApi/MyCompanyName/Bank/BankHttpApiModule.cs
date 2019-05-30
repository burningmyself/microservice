using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Bank
{
    [DependsOn(
        typeof(BankApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BankHttpApiModule : AbpModule
    {
        
    }
}
