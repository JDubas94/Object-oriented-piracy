using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_piracy1
{
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }
        public void IsWorthIt()
        {
            
            double rezult = Math.Abs(Crew * 1.5 - Draft);

            if (rezult > 20)
            {
                Console.WriteLine("Congratulations! Loot is on the ship!");
            }
            else
            {
                Console.WriteLine("You Lost! There is no loot on the ship!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(40, 10);

            ship.IsWorthIt();

            Console.ReadLine();
        }
    }
}
