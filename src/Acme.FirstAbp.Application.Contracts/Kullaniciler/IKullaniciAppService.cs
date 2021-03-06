using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.FirstAbp.Kullaniciler
{
   public interface IKullaniciAppService :
        ICrudAppService< //CRUD yöntemlerini tanımlar
            KullaniciDto, //Kullanıcıları gösterirken kullanılır
            Guid, //Kullanici birincil anahtarı
            PagedAndSortedResultRequestDto, //Sayfalama sıralama için kullanılır
            CreateUpdateKullaniciDto> //Kullanici oluşturmak/güncellemek için kullanılır
    {
        



    }
}
