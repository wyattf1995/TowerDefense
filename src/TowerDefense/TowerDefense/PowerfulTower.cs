using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
	class PowerfulTower : Tower
	{
		protected override int Range { get; } = 1;
		protected override double Power { get; } = 1.75;
		protected override double Accuracy { get; } = .6;

		public PowerfulTower(MapLocation location) : base(location)
		{
		}
	}
}