using System;

namespace builder
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose meat for your hamburger:");
            Console.WriteLine("1. beef");
            Console.WriteLine("2. chicken meat");
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

            Console.WriteLine("the propierties of your chosen meat are: " + hamburger.Meat.Color + ", " + hamburger.Meat.Textura);
        }
    }
}
