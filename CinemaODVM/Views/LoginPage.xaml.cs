using CinemaODVM.Domain;
using CinemaODVM.Helpers;
using CinemaODVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaODVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextUsuario.Text))
            {
                await DisplayAlert(Languages.Validation, Languages.ValidationMsgUser, Languages.OK);
                TextUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TextPassword.Text))
            {
                await DisplayAlert(Languages.Validation, Languages.ValidationMsgPw, Languages.OK);
                TextUsuario.Focus();
                return;
            }
            LoginRequest userInfo = new LoginRequest();
            userInfo.Usuario = TextUsuario.Text;
            userInfo.Password = TextPassword.Text;

            LoginResponse res = LoginService.SignIn(userInfo);
            if (res.Mensaje == Languages.OK)
            {

                await Navigation.PushAsync(new BillboardPage());
            }
            else
            {
                await DisplayAlert(Languages.Validation, Languages.IncorrectLogin, Languages.OK);
                TextUsuario.Focus();
                return;
            }
        }
    }
}