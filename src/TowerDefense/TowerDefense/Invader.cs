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

        //Health property for the invader that has get and set as public so other things can change the health of the invader (the tower)
        //declares its initial value to 2
        public int Health { get; set; } = 2;

        //Invader constructor
        public Invader(Path path)
        {
            _path = path;
        }

        //move method
        //moves to the next step on the path
        public void Move() => _pathStep += 1;

        //Method to decrease the health of the invader by a certain factor of damage
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
        
    }
}
