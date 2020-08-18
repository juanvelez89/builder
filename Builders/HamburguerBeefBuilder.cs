using System;
using System.Collections.Generic;
using System.Text;

namespace builder.Builders
{
    public class HamburguerBeefBuilder : IHamburguerBuilder
    {
        public Hamburguer hamburguer { get; set; }
        public HamburguerBeefBuilder()
        {
            hamburguer = GetHamburguer();
        }
        public override void AddMeat()
        {
            hamburguer.BeefMeat = new Ingredients.Beef();
        }

        public override void AddLettuce()
        {
            hamburguer.Lettuce = new Ingredients.Lettuce();
        }

        public override void AddOnion()
        {
            hamburguer.Onion = new Ingredients.Onion();
        }

        public override void AddTomato()
        {
            hamburguer.Tomato = new Ingredients.Tomato();
        }
    }
}
