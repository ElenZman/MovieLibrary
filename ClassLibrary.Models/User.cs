using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class User: IModel
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }


}
