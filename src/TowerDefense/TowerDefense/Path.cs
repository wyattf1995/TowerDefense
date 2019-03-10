using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Path
    {
        //Declares an array for the path coordinates
        private readonly MapLocation[] _path;

        //Constructor for Path class
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        //Method that returns 
        public MapLocation GetLocationAt(int pathStep)
        {
            //Ternary If statement
            //whats in parentheses is the condition for the if()
            //after the ? is what's returned while the condition is true
            //after the : is the else that is returned 
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
