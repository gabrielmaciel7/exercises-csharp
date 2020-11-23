using System;
using System.Collections.Generic;
using System.Text;

namespace _28
{
    class FiletSteak : IBeef
    {
        public int Kilos { get; set; }

        public FiletSteak(int kilos)
        {
            Kilos = kilos;
        }

        public float KiloPrice()
        {
            var price = Kilos switch
            {
                var kg when (kg <= 5) => 6.9F,
                _ => 7.8F
            };

            return price;
        }

        public float TotalPrice()
        {
            return Kilos * KiloPrice();
        }
    }
}
