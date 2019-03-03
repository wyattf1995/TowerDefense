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

        private int _pathStep = 0;

        public MapLocation Location { get; set; }

        public Invader(Path path)
        {
            _path = path;
            Location = path.GetLocationAt(_pathStep);
        }

        public void Move()
        {
            _pathStep += 1;
        }
        
    }
}
