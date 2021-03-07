using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.FirstAbp.Kullaniciler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.FirstAbp.Web.Pages.Kullaniciler
{
    public class EditModalModel : FirstAbpPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateKullaniciDto Kullanici { get; set; }

        private readonly IKullaniciAppService _kullaniciAppService;

        public EditModalModel(IKullaniciAppService kullaniciAppService)
        {
            _kullaniciAppService = kullaniciAppService;
        }

        public async Task OnGetAsync()
        {
            var kullaniciDto = await _kullaniciAppService.GetAsync(Id);
            Kullanici = ObjectMapper.Map<KullaniciDto, CreateUpdateKullaniciDto>(kullaniciDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _kullaniciAppService.UpdateAsync(Id, Kullanici);
            return NoContent();
        }
    }
}