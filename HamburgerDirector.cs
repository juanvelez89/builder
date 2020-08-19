using builder.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
    //Director
    public class HamburgerDirector
    {
        private HamburgerBeefBuilder hamburgerBeefBuilder;
        private HamburgerChickenBuilder hamburgerChickenBuilder;

        public Hamburger GetHamburgerBeef() 
        {
            hamburgerBeefBuilder = new HamburgerBeefBuilder();
            Hamburger hamburger = hamburgerBeefBuilder.GetHamburguer();
            hamburgerBeefBuilder.AddMeat(hamburger);
            return hamburger;
        }

        public Hamburger GetHamburgerChicken()
        {
            hamburgerChickenBuilder = new HamburgerChickenBuilder();
            Hamburger hamburger = hamburgerChickenBuilder.GetHamburguer();
            hamburgerChickenBuilder.AddMeat(hamburger);
            return hamburger;
        }
    }
}
