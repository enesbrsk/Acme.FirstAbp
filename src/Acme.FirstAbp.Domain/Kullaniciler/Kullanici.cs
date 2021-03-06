using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.FirstAbp.Kullaniciler
{
    public class Kullanici  : AuditedAggregateRoot<Guid>
    {
        // Kullanıcı Bilgileri 

        public string Name { get; set; }

        public KullaniciType Type { get; set; }
        public string  Surname { get; set; }

        public int Num { get; set; }


    }
}
