using System.Threading.Tasks;

namespace App2.Interfaces
{
    public interface IPageService
    {
        Task DisplayAlert(string title, string content, string ok);
    }
}
