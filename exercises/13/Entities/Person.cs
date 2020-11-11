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
            return (72.7F * Height) - 58;
        }

        public float IdealWeightForWomen()
        {
            return (62.1F * Height) - 44.7F;
        }
    }
}
