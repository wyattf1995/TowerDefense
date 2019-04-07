using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
		private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

		public bool IsSuccesfulShot()
		{
			return _random.NextDouble() < _accuracy;
		}


        public void FireOnInvaders(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
               //Checks whether the invader is active and within the declared range of 1 and if so fires upon it
               if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
					if (IsSuccesfulShot())
					{
						//decreases health of the invader by 1
						invader.DecreaseHealth(_power);
						Console.WriteLine("Shot at and hit an invader!");
					}
					else
					{
						Console.WriteLine("Shot at and missed an invader.");
					}
					break;
                }
            }
        }
    }
}
