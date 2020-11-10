using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Entities
{
    class Square
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public float Area()
        {
            return Side * Side;
        }
    }
}
