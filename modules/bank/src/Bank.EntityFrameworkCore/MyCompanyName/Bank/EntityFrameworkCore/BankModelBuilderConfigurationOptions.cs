using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Bank.EntityFrameworkCore
{
    public class BankModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public BankModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = BankConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = BankConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}