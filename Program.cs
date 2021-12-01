using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Nokia nokia= new Nokia("First",100,"Cricket","Bzzzzzzzz");
            nokia.DisplayInfo();
            Console.WriteLine(nokia.Ring());
            Console.WriteLine(nokia.Unlock());
            Console.WriteLine("");

            Galaxy galaxy = new Galaxy("S8",100,"T-mobile","DOO DODOO");
            galaxy.DisplayInfo();
            Console.WriteLine(galaxy.Ring());
            Console.WriteLine(galaxy.Unlock());
            

        }
    }
}
