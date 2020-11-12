using System;
using System.Collections.Generic;
using System.Text;

namespace _17.Entities
{
    abstract class Paint
    {
        private protected float _paintRate = (1F / 6);

        public float Area { get; set; }

        public Paint(float area)
        {
            Area = area;
        }

        public float LitersRequired()
        {
            return _paintRate * Area;
        }
    }
}
