using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.FirstAbp.Pages
{
    public class Index_Tests : FirstAbpWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
