using System.Threading.Tasks;
using App2.Interfaces;
using Xamarin.Forms;

namespace App2.Services
{
    class PageService : IPageService
    {
        private readonly Page _page;
        public PageService(Page page)
        {
            _page = page;
        }

        public async Task DisplayAlert(string title, string content, string ok)
        {
              await _page.DisplayAlert(title, content, ok);
        }
    }
}
