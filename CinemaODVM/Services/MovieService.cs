using CinemaODVM.Domain;
using CinemaODVM.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaODVM.Services
{
    class MovieService
    {
        public static List<Movie> GetMovies()
        {
            var movies = MoviesAPIHelper.Get<List<Movie>>("");
            return movies;
        }
    }
}
