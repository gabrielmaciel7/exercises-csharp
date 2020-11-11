using System;
using System.Collections.Generic;
using System.Text;

namespace _13.Entities
{
    class Person
    {
        public float Height { get; set; }

        public Person(float height)
        {
            Height = height;
        }

        public float IdealWeightForMen()
        {
            return ((float)72.7 * Height) - 58;
        }

        public float IdealWeightForWomen()
        {
            return ((float)62.1 * Height) - (float)44.7;
        }
    }
}
