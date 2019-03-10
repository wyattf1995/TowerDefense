using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private readonly Path _path;

        //initial starting place on path, not readonly because it will change over time
        private int _pathStep = 0;

        //Location property
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        //Invader constructor
        public Invader(Path path)
        {
            _path = path;
        }

        //move method
        //moves to the next step on the path
        public void Move()
        {
            _pathStep += 1;
        }
        
    }
}
