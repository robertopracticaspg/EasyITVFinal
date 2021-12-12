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
    public partial class PageEjes : ContentPage
    {
        public PageEjes()
        {
            InitializeComponent();
        }
        private async void exit_Clicked_PagePrincipal(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}