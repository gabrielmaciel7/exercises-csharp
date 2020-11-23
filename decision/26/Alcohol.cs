using System;
using System.Collections.Generic;
using System.Text;

namespace _26
{
    class Alcohol
    {
        private readonly float _literPrice = 1.9F;
        public int Liters { get; set; }

        public Alcohol(int liters)
        {
            Liters = liters;
        }

        public float DiscountRate()
        {
            var discountRate = Liters switch
            {
                var l when (l <= 20) => 0.03F,
                _ => 0.05F
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
