using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth.Entities.Concrete
{
    public class Reservation : EntityBase
    {
        public string FullName { get; set; }
        public string Telephone { get; set; } 
        public string OrgazinationDate { get; set; } 
        public int Guests { get; set; } 
        public string Email { get; set; } 
        public string Time { get; set; } 
    }
}
