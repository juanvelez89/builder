using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
    public abstract class IHamburguerBuilder
    {
        public abstract void AddMeat();
        public abstract void AddTomato();
        public abstract void AddLettuce();
        public abstract void AddOnion();

        public Hamburguer GetHamburguer()
        {
            return new Hamburguer();
        }
    }
}
