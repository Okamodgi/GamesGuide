using GamesGuide.Models;
using GamesGuide.ViewModels;
using GamesGuide.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GamesGuide.Views
{
    public partial class FavoritePage : ContentPage
    {
        ItemsViewModel _viewModel;

        public FavoritePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}