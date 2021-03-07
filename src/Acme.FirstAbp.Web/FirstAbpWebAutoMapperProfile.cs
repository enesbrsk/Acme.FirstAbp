using Acme.FirstAbp.Kullaniciler;
using AutoMapper;

namespace Acme.FirstAbp.Web
{
    public class FirstAbpWebAutoMapperProfile : Profile
    {
        public FirstAbpWebAutoMapperProfile()
        {
            // KullaniciDto ile CreateUpdateKullaniciDto eşleştirme
            CreateMap<KullaniciDto, CreateUpdateKullaniciDto>();

        }
    }
}
