using System;
using System.Collections.Generic;
using System.Text;

namespace builder.Builders
{
    public class HamburguerChickenBuilder : IHamburguerBuilder
    {
        public Hamburguer hamburguer { get; set; }
        public HamburguerChickenBuilder()
        {
            hamburguer = GetHamburguer();
        }

        public override void AddMeat()
        {
            throw new NotImplementedException();
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
