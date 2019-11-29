using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AccesibilidadDemo.Pages
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
        }

        async void OnImageTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Suceso", "Click en la imagen de forma correcta", "Ok");
        }
    }
}
