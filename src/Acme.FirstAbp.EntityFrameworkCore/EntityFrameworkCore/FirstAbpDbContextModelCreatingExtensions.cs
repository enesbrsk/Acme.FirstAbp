using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.FirstAbp.EntityFrameworkCore
{
    public static class FirstAbpDbContextModelCreatingExtensions
    {
        public static void ConfigureFirstAbp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FirstAbpConsts.DbTablePrefix + "YourEntities", FirstAbpConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}