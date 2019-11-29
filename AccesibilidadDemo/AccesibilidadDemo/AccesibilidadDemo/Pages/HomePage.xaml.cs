﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccesibilidadDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Texto1_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextoFijoPage());
        }

        private async void Texto2_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextoSistemaPage());
        }

        private async void Texto3_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StylePage());
        }

        private async void Formulario_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormularioPage());
        }

        private async void Imagen_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagePage());
        }

        private async void Texto4_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextoContrastePage());
        }


    }
}