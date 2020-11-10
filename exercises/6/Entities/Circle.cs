using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Entities
{
    class Circle
    {
        private readonly double _pi = Math.PI;

        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return _pi * Radius * Radius;
        }
    }
}
