using builder.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
    //product
    public class Hamburger
    {
        public Meat Meat { get; set; }
        public Lettuce Lettuce { get; set; }
        public Onion Onion { get; set; }
        public Tomato Tomato { get; set; }

    }
}
