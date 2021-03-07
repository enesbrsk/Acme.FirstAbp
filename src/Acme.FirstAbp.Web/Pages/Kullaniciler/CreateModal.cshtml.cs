using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.FirstAbp.Kullaniciler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.FirstAbp.Web.Pages.Kullaniciler
{
    public class CreateModalModel : AbpPageModel
    {
        [BindProperty]
        public CreateUpdateKullaniciDto Kullanici { get; set; }
        private IKullaniciAppService _kullaniciAppService;

        public CreateModalModel(IKullaniciAppService kullaniciAppService)
        {

            _kullaniciAppService = kullaniciAppService;
        }
        public void OnGet()
        {
            Kullanici = new CreateUpdateKullaniciDto();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _kullaniciAppService.CreateAsync(Kullanici);
            return NoContent();
        }
    }
}
