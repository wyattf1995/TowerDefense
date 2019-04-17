using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
		protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

		public bool IsSuccesfulShot()
		{
			return _random.NextDouble() < Accuracy;
		}


        public void FireOnInvaders(Invader[] invaders)
        {

            foreach (Invader invader in invaders)
            {
               //Checks whether the invader is active and within the declared range of 1 and if so fires upon it
               if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
					if (IsSuccesfulShot())
					{
						//decreases health of the invader by 1
						invader.DecreaseHealth(Power);
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
