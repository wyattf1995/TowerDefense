﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
	class StrongInvader : Invader
	{
		public override double Health => base.Health;
		public StrongInvader(Path path) : base(path)
		{
			
		}
	}
}
