using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.BusinessObjects
{
    class MovieClass
    {
        public int MovieNumber { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public int MovieYear { get; set; }
        public int GenreID { get; set; }
        public string MovieRating { get; set; }
        public string MediaType { get; set; }
        public string MovieRetailCost { get; set; }
        public int CopiesOnHand { get; set; }
        public string MovieImage { get; set; }
        public string MovieTrailer { get; set; }
    }
}
