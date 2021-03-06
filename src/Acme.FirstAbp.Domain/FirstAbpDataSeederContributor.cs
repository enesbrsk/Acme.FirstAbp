using System;
using System.Threading.Tasks;
using Acme.FirstAbp;
using Acme.FirstAbp.Kullaniciler;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.FirstAbp
{
    public class FirstAbpDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Kullanici, Guid> _bookRepository;

        public FirstAbpDataSeederContributor(IRepository<Kullanici, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        // Statik bir veri tabanı
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Kullanici
                    {
                        Name = "Mustafa",
                        Type = KullaniciType.ScienceFiction,
                        Surname = "Birişik",
                        Num = 123456789
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Kullanici
                    {
                        Name = "Enes",
                        Type = KullaniciType.ScienceFiction,
                        Surname = "Birişik",
                        Num = 0507078724
                    },
                    autoSave: true
                );
            }
        }
    }
}
