using System;
using System.Collections.Generic;
using System.Text;

namespace builder.Builders
{
    public class HamburgerBeefBuilder : IHamburgerBuilder
    {

        public override void AddMeat(Hamburger hamburger)
        {
            hamburger.Meat = new Ingredients.Meat();
            hamburger.Meat.Color = "red";
            hamburger.Meat.Textura = "hard";
        }

        public override void AddLettuce(Hamburger hamburger)
        {
            hamburger.Lettuce = new Ingredients.Lettuce();
        }

        public override void AddOnion(Hamburger hamburger)
        {
            hamburger.Onion = new Ingredients.Onion();
        }

        public override void AddTomato(Hamburger hamburger)
        {
            hamburger.Tomato = new Ingredients.Tomato();
        }
    }
}
