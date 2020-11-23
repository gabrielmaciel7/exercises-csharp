using System;
using System.Collections.Generic;
using System.Text;

namespace _26
{
    class Gasoline
    {
        private readonly float _literPrice = 2.5F;
        public int Liters { get; set; }

        public Gasoline(int liters)
        {
            Liters = liters;
        }

        public float DiscountRate()
        {
            var discountRate = Liters switch
            {
                var l when (l <= 20) => 0.04F,
                _ => 0.06F
            };

            return discountRate;
        }

        public float Price()
        {
            var priceWithoutDiscount = Liters * _literPrice;
            var discount = DiscountRate() * priceWithoutDiscount;

            return priceWithoutDiscount - discount;
        }
    }
}
