using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth.Entities.Concrete
{
    public class Food : EntityBase
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public Category Category { get; set; }
    }
}
