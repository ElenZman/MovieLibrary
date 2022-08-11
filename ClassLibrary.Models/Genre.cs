using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Genre: IModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
