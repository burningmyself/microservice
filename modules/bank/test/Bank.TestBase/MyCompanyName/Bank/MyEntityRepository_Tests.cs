using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace Bank
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : BankTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
