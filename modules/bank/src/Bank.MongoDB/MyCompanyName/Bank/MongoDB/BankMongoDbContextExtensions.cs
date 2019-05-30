using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Bank.MongoDB
{
    public static class BankMongoDbContextExtensions
    {
        public static void ConfigureBank(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BankMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}