using Acme.FirstAbp.Kullaniciler;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.FirstAbp.EntityFrameworkCore
{
    public static class FirstAbpDbContextModelCreatingExtensions
    {
        public static void ConfigureFirstAbp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Kullanici>(b =>
            {
                b.ToTable(FirstAbpConsts.DbTablePrefix + "Kullaniciler", FirstAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);


            });
        }
    }
}