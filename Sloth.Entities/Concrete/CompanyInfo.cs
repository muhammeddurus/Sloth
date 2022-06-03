using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth.Entities.Concrete
{
    public class CompanyInfo : EntityBase
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Location { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyName { get; set; }
        public string CompanyMobile { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyText { get; set; }


        //Social
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
    }
}
