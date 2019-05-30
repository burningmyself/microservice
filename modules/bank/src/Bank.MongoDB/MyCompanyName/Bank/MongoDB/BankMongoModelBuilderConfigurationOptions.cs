using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Bank.MongoDB
{
    public class BankMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public BankMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = BankConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}