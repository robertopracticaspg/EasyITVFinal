using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasyITVInicio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }          
        private void Button_Clicked_Inicio(object sender, EventArgs e)
        {
            string strUsuario = txtUsuario.Text;
            string strContraseña = txtContraseña.Text;

            if((strUsuario=="Roberto") && (strContraseña=="0000"))
            {
                Navigation.PushAsync(new PageTrabajadores());
            }

            if ((strUsuario == "Laura") && (strContraseña == "0001"))
            {
                Navigation.PushAsync(new PageTrabajadores());
            }

            if ((strUsuario == "Marta") && (strContraseña == "0002"))
            {
                Navigation.PushAsync(new PageTrabajadores());
            }

            if ((strUsuario == "Adrian") && (strContraseña == "0003"))
            {
                Navigation.PushAsync(new PageTrabajadores());
            }
            else 
            {
                lblResultado.Text = "Usuario o Contraseña incorrectos!";
            }
            
        }
    }
}
