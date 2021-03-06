using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.FirstAbp.Kullaniciler
{
    class KullaniciDto : AuditedEntityDto<Guid>
    {
        // Kullanıcı Bilgileri 
        public string Name { get; set; }
        public KullaniciType Type { get; set; }
        public string Surname { get; set; }
        public int Num { get; set; }
    }
}
