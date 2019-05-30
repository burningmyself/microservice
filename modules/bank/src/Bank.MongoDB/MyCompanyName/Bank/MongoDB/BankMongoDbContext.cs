using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Bank.MongoDB
{
    [ConnectionStringName("Bank")]
    public class BankMongoDbContext : AbpMongoDbContext, IBankMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = BankConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBank(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}