using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class TowerDefenseException : Exception
    {
        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
