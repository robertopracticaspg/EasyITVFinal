using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EasyITVInicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }
        private async void exit_Clicked_PageMatricula(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void exit_Clicked_PageTrabajadores(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void nextBtn_Clicked_Camara(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFoto());
        }
        private async void nextBtn_Clicked_Informe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageInforme());
        }
   
        private async void nextBtn_Clicked_Identificacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageIdentificacion());
        }
        private async void exit_Clicked_PagePrincipal(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void nextBtn_Clicked_Exterior(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageExterior());
        }
        private async void nextBtn_Clicked_Interior(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageInterior());
        }
        private async void nextBtn_Clicked_Alumbrado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAlumbrado());
        }
        private async void nextBtn_Clicked_Emisiones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageEmisiones());
        }
        private async void nextBtn_Clicked_Frenos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFrenos());
        }
        private async void nextBtn_Clicked_Direccion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDireccion());
        }
        private async void nextBtn_Clicked_Ejes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageEjes());
        }
         private async void nextBtn_Clicked_Motor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageMotor());
        }
        private async void nextBtn_Clicked_Otros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageOtros());
        }

        private void ImageButton_Clicked_Internet(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.aeca-itv.com/publicaciones/", BrowserLaunchMode.SystemPreferred);
        }
    }
}