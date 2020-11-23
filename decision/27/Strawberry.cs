using System;
using System.Collections.Generic;
using System.Text;

namespace _27
{
    class Strawberry
    {
        public int Kilos { get; set; }

        public Strawberry(int kilos)
        {
            Kilos = kilos;
        }

        public float KiloPrice()
        {
            var price = Kilos switch
            {
                var kg when (kg <= 5) => 2.5F,
                _ => 2.2F
            };

            return price;
        }

        public float Discount(float price)
        {
            if (Kilos > 8 || price > 25)
            {
                return price * 0.1F;
            }

            return 0;
        }

        public float TotalPrice()
        {
            var price = Kilos * KiloPrice();

            return price - Discount(price);
        }
    }
}
