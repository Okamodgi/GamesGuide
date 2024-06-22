using GamesGuide.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GamesGuide.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await NavigateToItemsPage());
        }

        public ICommand OpenWebCommand { get; }
        

        private async Task NavigateToItemsPage()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new ItemsPage());
        }
    }
}