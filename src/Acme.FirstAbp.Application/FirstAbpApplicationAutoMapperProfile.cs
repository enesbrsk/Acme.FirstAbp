using Acme.FirstAbp.Kullaniciler;
using AutoMapper;

namespace Acme.FirstAbp
{
    public class FirstAbpApplicationAutoMapperProfile : Profile
    {
        public FirstAbpApplicationAutoMapperProfile()
        {
             CreateMap<Kullanici, KullaniciDto>();
            CreateMap<CreateUpdateKullaniciDto, Kullanici>();


        }
    }
}
