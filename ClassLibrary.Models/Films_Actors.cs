using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Films_Actors: IModel
    {
        public int? Id { get; set; }
        public int FilmId { get; set; }
        public int ActorId { get; set; }
    }
}
