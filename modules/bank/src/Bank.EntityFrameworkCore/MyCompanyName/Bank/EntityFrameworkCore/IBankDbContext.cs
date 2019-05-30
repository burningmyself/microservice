using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Bank.EntityFrameworkCore
{
    [ConnectionStringName("Bank")]
    public interface IBankDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}