using System;
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
    }
}