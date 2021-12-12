using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyITVInicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTrabajadores : ContentPage
    {
        public PageTrabajadores()
        {
            InitializeComponent();
        }
        private async void nextBtn_Clicked_Matricula(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageMatricula());
        }
    }
    
}