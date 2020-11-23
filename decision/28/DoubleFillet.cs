using System;
using System.Collections.Generic;
using System.Text;

namespace _28
{
    class DoubleFillet : IBeef
    {
        public int Kilos { get; set; }

        public DoubleFillet(int kilos)
        {
            Kilos = kilos;
        }

        public float KiloPrice()
        {
            var price = Kilos switch
            {
                var kg when (kg <= 5) => 4.9F,
                _ => 5.8F
            };

            return price;
        }

        public float TotalPrice()
        {
            return Kilos * KiloPrice();
        }
    }
}
