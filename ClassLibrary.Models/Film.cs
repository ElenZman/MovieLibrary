using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Film: IModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int Year { get; set; }
        public byte[] Poster { get; set; }
        public int CountryId { get; set; }
        public int DirectorId { get; set; }
        public decimal Rate { get; set; }
        public string Summary { get; set; }
        public int PeopleRatedNumber { get; set; }
    }
}
