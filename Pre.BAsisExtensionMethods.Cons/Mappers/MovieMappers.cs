using Pre.BasisExtensionMethods.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Cons.Mappers
{
    public static class MovieMappers
    {
        //Maps to a MoviesIndexViewModel
        public static MoviesIndexViewModel MapToViewModel(this Movie movie)
        {
            return new MoviesIndexViewModel
            {
                Title = movie.Title,
                Genre = movie.Genre,
                Actors = movie.Actors
            };
        }
        //Maps to a IEnumerable<MoviesIndexViewModel>
        public static IEnumerable<MoviesIndexViewModel> MapToViewModels(this IEnumerable<Movie> movies)
        {
            return movies.Select(m => m.MapToViewModel());
        }
    }
}
