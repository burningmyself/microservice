using Bank.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Bank
{
    [DependsOn(
        typeof(BankEntityFrameworkCoreTestModule)
        )]
    public class BankDomainTestModule : AbpModule
    {
        
    }
}
