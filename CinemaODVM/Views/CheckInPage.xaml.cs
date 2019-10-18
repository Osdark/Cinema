using CinemaODVM.Domain;
using CinemaODVM.Helpers;
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
    public partial class CheckInPage : ContentPage
    {
        private SelectedMovie selectedMovie;
        
        public CheckInPage(SelectedMovie selectedMovie)
        {
            InitializeComponent();
            this.selectedMovie = selectedMovie;
            BindingContext = selectedMovie;
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert(Languages.Success, Languages.SuccessMsgBuy, Languages.OK);
        }
    }
}