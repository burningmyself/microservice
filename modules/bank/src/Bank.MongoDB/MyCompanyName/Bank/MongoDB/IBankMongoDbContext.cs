using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Bank.MongoDB
{
    [ConnectionStringName("Bank")]
    public interface IBankMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
