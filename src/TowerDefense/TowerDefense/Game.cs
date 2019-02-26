using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (Exception)
            {
                Console.WriteLine("That point is not on the map!");
            }

            Console.ReadKey();

        }
    }
}
