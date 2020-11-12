using System;
using System.Collections.Generic;
using System.Text;

namespace _17.Entities
{
    class ICalculateAmountPaintCanAndGallon
    {
        public int paintCans;
        public int paintGallons;
    }

    class ICalculatePriceCanAndGallon
    {
        public float paintCansPrice;
        public float paintGallonsPrice;
    }

    class PaintCanAndGallon : Paint
    {
        private readonly float _slack = 0.1F;

        public PaintCan PaintCan { get; set; }
        public PaintGallon PaintGallon { get; set; }

        public PaintCanAndGallon(float area) : base(area) 
        {
            var areaWithSlack = area * (1 + _slack);

            Area = areaWithSlack;

            PaintCan = new PaintCan(Area);
            var cansNoWaste = PaintCan.CalculateNoWaste();

            PaintGallon = new PaintGallon(cansNoWaste.missingArea);
        }

        public ICalculateAmountPaintCanAndGallon CalculateAmount()
        {
            var result = new ICalculateAmountPaintCanAndGallon
            {
                paintCans = PaintCan.CalculateNoWaste().cansRequired,
                paintGallons = PaintGallon.CalculateAmount()
            };

            return result;
        }

        public ICalculatePriceCanAndGallon CalculatePrice()
        {
            var result = new ICalculatePriceCanAndGallon
            {
                paintCansPrice = PaintCan.CalculateNoWaste().cansPrice,
                paintGallonsPrice = PaintGallon.CalculatePrice()
            };

            return result;
        }
    }
}
