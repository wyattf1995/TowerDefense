using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        //Initalizes two fields, one for each coordinate
        public readonly int X;
        public readonly int Y;

        //Constructor for Point class
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Method for determining distance between two points
        public int DistanceTo(int x, int y)
        {
            return (int) Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        //Overloaded method that is just passed a single Point argument
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
