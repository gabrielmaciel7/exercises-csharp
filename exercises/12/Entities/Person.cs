using System;
using System.Collections.Generic;
using System.Text;

namespace _12.Entities
{
    class Person
    {
        public float Height { get; set; }

        public Person(float height)
        {
            Height = height;
        }

        public float IdealWeight()
        {
            return (72.7F * Height) - 58;
        }
    }
}
