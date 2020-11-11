using System;
using System.Collections.Generic;
using System.Text;

namespace _15.Entities
{
    class Employee
    {
        private readonly float _ir = 0.11F;
        private readonly float _inss = 0.08F;
        private readonly float _union = 0.05F;

        public float GainPerHour { get; set; }
        public int WorkedHours { get; set; }

        public Employee(float gainPerHour, int workedHours)
        {
            GainPerHour = gainPerHour;
            WorkedHours = workedHours;
        }

        public float GrossWage()
        {
            return GainPerHour * WorkedHours;
        }

        public float IR()
        {
            return GrossWage() * _ir;
        }

        public float INSS()
        {
            return GrossWage() * _inss;
        }

        public float Union()
        {
            return GrossWage() * _union;
        }

        public float NetSalary()
        {
            var discounts = IR() + INSS() + Union();

            return GrossWage() - discounts;
        }
    }
}
