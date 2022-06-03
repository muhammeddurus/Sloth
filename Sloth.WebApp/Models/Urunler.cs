using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sloth.WebApp.Models
{
    public class Urunler
    {
        public Urunler()
        {

        }

        

        public Urunler(int urunid, string title, string desc, decimal price, string image, int catid, string text)
        {
            this.urunid = urunid;
            this.catid = catid;
            this.title = title;
            this.text = text;
            this.image = image;
            this.desc = desc;
            this.price = price;

        }

        public int urunid { get; set; }
        public int catid { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string text { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }

    }
}