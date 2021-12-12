using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyITVInicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMatricula : ContentPage
    {
        public PageMatricula()
        {
            InitializeComponent();
        }
        private async void exit_Clicked_Trabajadores(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private void Button_Clicked_V(object sender, EventArgs e)
        {
            DisplayAlert("8781FVS", "Numero de informe: 0000001\nMarca: Opel\nModelo: Vectra\nAño de fabricacion: 2007\nCombustible: Diesel\nNeumaticos:215/55R16 91V", "ok");
        }
        private void Button_Clicked_F(object sender, EventArgs e)
        {
            DisplayAlert("9512GXR", "Numero de informe: 0000002\nMarca: Ford\nModelo: Focus\nAño de fabricacion: 2009\nCombustible: Diesel\nNeumaticos:205/55R16 91V", "ok");
        }
        private void Button_Clicked_M(object sender, EventArgs e)
        {
            DisplayAlert("0798HHR", "Numero de informe: 0000003\nMarca: Mazda\nModelo: 2\nAño de fabricacion: 2011\nCombustible: Gasolina\nNeumaticos:195/55R15 87H", "ok");
        }
        private void Button_Clicked_L(object sender, EventArgs e)
        {
            DisplayAlert("7447LBD", "Numero de informe: 0000004\nMarca: Seat\nModelo: León\nAño de fabricacion: 2017\nCombustible: Diesel\nNeumaticos:225/45R17 94W", "ok");
        }
        private void Button_Clicked_R6(object sender, EventArgs e)
        {
            DisplayAlert("SG0348F", "Numero de informe: 0000005\nMarca: Renault\nModelo: 6\nAño de fabricacion: 1974\nCombustible: Gasolina\nNeumaticos:145/65R3 80T", "ok");
        }
        private void Button_Clicked_Y(object sender, EventArgs e)
        {
            DisplayAlert("E0998BBC", "Numero de informe: 0000006\nMarca: Yamaha\nModelo: Raptor\nAño de fabricacion: 2004\nCombustible: Gasolina\nNeumaticos:11.5 10 58W", "ok");
        }
        private void Button_Clicked_P(object sender, EventArgs e)
        {
            DisplayAlert("4588HCT", "Numero de informe: 0000007\nMarca: Peugeot\nModelo: 508\nAño de fabricacion: 2014\nCombustible: Diesel\nNeumaticos:205/55R16 91V", "ok");
        }
        private void Button_Clicked_A(object sender, EventArgs e)
        {
            DisplayAlert("7935JDT", "Numero de informe: 0000008\nMarca: Audi\nModelo: A3\nAño de fabricacion: 2016\nCombustible: Diesel\nNeumaticos:205/55R16 91V", "ok");
        }
        private void Button_Clicked_T(object sender, EventArgs e)
        {
            DisplayAlert("6021LBD", "Numero de informe: 0000009\nMarca: Toyota\nModelo: Corolla\nAño de fabricacion: 2017\nCombustible: Hibrido\nNeumaticos:225/45R17 94W", "ok");
        }


        private async void nextBtn_Clicked_PagePrincipal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePrincipal());
        }

    }
}