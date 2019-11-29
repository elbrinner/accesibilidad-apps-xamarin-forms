using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesibilidadDemo.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AccesibilidadDemo.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioPage : ContentPage
    {
        public FormularioPage()
        {
            InitializeComponent();
        }

        private async void Summit_click(object sender, EventArgs e)
        {

            MiActivityIndicator.IsRunning = true;

            DependencyService.Get<IAccessibility>().PostVoiceOver("Enviando los datos al servidor, espere unos segundos");

            //simulando llamada al servidor
            await Task.Delay(10000);

            MiActivityIndicator.IsRunning = false;

           await DisplayAlert("Suceso","Datos enviados con exito","0k");


        }

        private async void Summit_click0(object sender, EventArgs e)
        {

            MiActivityIndicator.IsRunning = true;

           
            await Task.Delay(35000);
            await DisplayAlert("Suceso", "Datos enviados con exito", "0k");


        }


    }
}
