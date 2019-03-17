using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    //inherits from the Point class
    class MapLocation : Point
    {
        //Constructor initializes the MapLocation object
        //which inherits from and is itself a Point
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            //This if statement determines if the MapLocation point is outside the boundaries of the Map
            //and if so throws an OutOfBoundsException
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + ", " + y + " is outside the boundaries of the map.");
            }
        }
    }
}
