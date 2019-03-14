using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotWebApi.ModelState
{
    public class ProductState
    {
        public string Categorie { get; set; }

        public double PriceMin { get; set; }

        public double PriceMax { get; set; }
    }
}
