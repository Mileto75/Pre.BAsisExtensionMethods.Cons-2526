using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.BasisExtensionMethods.Cons
{
    public class MoviesIndexViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public IEnumerable<string> Actors { get; set; }
    }
}
