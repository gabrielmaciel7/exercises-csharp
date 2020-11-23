using System;
using System.Collections.Generic;
using System.Text;

namespace _28
{
    class Rump : IBeef
    {
        public int Kilos { get; set; }

        public Rump(int kilos)
        {
            Kilos = kilos;
        }

        public float KiloPrice()
        {
            var price = Kilos switch
            {
                var kg when (kg <= 5) => 5.9F,
                _ => 6.8F
            };

            return price;
        }

        public float TotalPrice()
        {
            return Kilos * KiloPrice();
        }
    }
}
