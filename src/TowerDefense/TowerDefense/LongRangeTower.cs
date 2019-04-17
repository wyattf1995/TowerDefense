using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
	class LongRangeTower : Tower
	{
		protected override int Range { get; } = 3;
		protected override double Power { get; } = .75;
		protected override double Accuracy { get; } = .8;

		public LongRangeTower(MapLocation location) : base(location)
		{
		}
	}
}
