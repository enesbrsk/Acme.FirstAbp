using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.FirstAbp.Kullaniciler
{
   public class KullaniciAppService :
         CrudAppService<
            Kullanici, 
            KullaniciDto, 
            Guid,
            PagedAndSortedResultRequestDto, 
            CreateUpdateKullaniciDto>, 
        IKullaniciAppService

    {
        public KullaniciAppService(IRepository<Kullanici, Guid> repository)
            : base(repository)
        {

        }
    }
}
