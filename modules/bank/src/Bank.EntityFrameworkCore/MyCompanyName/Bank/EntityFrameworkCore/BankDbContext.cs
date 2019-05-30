using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Bank.EntityFrameworkCore
{
    [ConnectionStringName("Bank")]
    public class BankDbContext : AbpDbContext<BankDbContext>, IBankDbContext
    {
        public static string TablePrefix { get; set; } = BankConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = BankConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public BankDbContext(DbContextOptions<BankDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBank(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}