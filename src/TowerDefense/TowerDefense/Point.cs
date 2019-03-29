using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        //Constructor initializes the Point object
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Method that takes a set of coordinates as parameters and returns
        //the distance between the passed paramters and the current point location
        public int DistanceTo(int x, int y)
        {
            return (int) Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        //Overload the method to make it take just a point as a parameter
        //so that the distance between any two arbitrary points can be calculated
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
