using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchCustomNavigationPage.ViewModels
{
    public class SearchPageViewModel : BaseViewModel
    {
        public SearchPageViewModel()
        {
            SearchCommand = new Command(async (object obj) =>
            {
                using (var client = new HttpClient())
                {
                    SearchResult = await client.GetStringAsync("https://www.googleapis.com/customsearch/v1?key=AIzaSyD44XPaSG0I-jqOSXCWlQCOJtQ4WiN-c4o&cx=017576662512468239146:omuauf_lfve&q=" + obj);
                }
            });
        }

        public ICommand SearchCommand { get; }

        public string SearchResult
        {
            get
            {
                return searchResult;
            }

            set
            {
                SetProperty(ref searchResult, value);
            }
        }

        private string searchResult;
    }
}
