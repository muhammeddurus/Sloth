using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth.Entities.Concrete
{
    public class Contact : EntityBase
    {
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
