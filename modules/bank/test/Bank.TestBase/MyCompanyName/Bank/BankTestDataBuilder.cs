using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace Bank
{
    public class BankTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private BankTestData _testData;

        public BankTestDataBuilder(
            IGuidGenerator guidGenerator,
            BankTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}