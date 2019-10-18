using CinemaODVM.Domain;
using CinemaODVM.Services;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaODVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BillboardPage : ContentPage
    {
        public BillboardPage()
        {
            InitializeComponent();
            List<Movie> movies = MovieService.GetMovies();
            Movies.ItemsSource = movies;
        }

        private async void Movie_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var movie = (Movie)e.SelectedItem;
            await Navigation.PushAsync(new Functions(movie));
        }
    }
}