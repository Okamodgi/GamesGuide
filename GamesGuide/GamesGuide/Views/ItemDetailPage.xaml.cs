﻿using GamesGuide.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GamesGuide.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}