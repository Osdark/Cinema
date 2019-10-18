using CinemaODVM.Domain;
using CinemaODVM.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaODVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Functions : ContentPage
    {
        private Movie movie;
        public Functions(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            BindingContext = movie;
        }

        private async void Function_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextTickets.Text))
            {
                await DisplayAlert(Languages.Validation, Languages.ValidationMsgTicket, Languages.OK);
                TextTickets.Focus();
                return;
            }
            else
            {
                Function function = (Function)e.SelectedItem;
                SelectedMovie selectedMovie = new SelectedMovie();
                selectedMovie.Nombre = movie.Nombre;
                selectedMovie.FechaEstreno = movie.FechaEstreno;
                selectedMovie.Imagen = movie.Imagen;
                selectedMovie.FuncionSeleccionada = function;
                selectedMovie.Tiquetes = System.Convert.ToInt32(TextTickets.Text);
                selectedMovie.PrecioTotal = selectedMovie.Tiquetes * function.Precio;
                await Navigation.PushAsync(new CheckInPage(selectedMovie));
            }
        }
    }
}