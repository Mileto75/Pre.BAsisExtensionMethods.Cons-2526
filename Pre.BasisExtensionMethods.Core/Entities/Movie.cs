using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Core.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime YearPublished { get; set; }
        public int? Rating { get; set; }
        public string Summary { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public ICollection<string> Actors { get; set; }
    }
}
