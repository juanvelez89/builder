using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
    //builder
    public abstract class IHamburgerBuilder
    {
        public abstract void AddMeat(Hamburger hamburger);
        public abstract void AddTomato(Hamburger hamburger);
        public abstract void AddLettuce(Hamburger hamburger);
        public abstract void AddOnion(Hamburger hamburger);

        public Hamburger GetHamburguer()
        {
            return new Hamburger();
        }
    }
}
