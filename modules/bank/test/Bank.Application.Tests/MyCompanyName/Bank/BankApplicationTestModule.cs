using Volo.Abp.Modularity;

namespace Bank
{
    [DependsOn(
        typeof(BankApplicationModule),
        typeof(BankDomainTestModule)
        )]
    public class BankApplicationTestModule : AbpModule
    {

    }
}
