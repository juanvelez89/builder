using System;

namespace builder
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("por favor escoja su hamburguesa:");
            Console.WriteLine("1. para carne de res");
            Console.WriteLine("2. para carnde de pollo");
            int opcionHamburger = int.Parse(Console.ReadLine());
            HamburgerDirector hamburgerDirector = new HamburgerDirector();
            Hamburger hamburger = new Hamburger();
            switch (opcionHamburger)
            {
                case 1:
                    hamburger = hamburgerDirector.GetHamburgerBeef();
                    break;
                case 2:
                    hamburger = hamburgerDirector.GetHamburgerChicken();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Esta es las propiedades de la carne elegida: " + hamburger.Meat.Color + ", " + hamburger.Meat.Textura);
        }
    }
}
