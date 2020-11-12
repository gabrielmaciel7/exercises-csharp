using System;
using System.Collections.Generic;
using System.Text;

namespace _17.Entities
{
    class PaintGallon : Paint
    {
        private readonly float _gallonSize = 3.6F;
        private readonly float _unitPrice = 25F;

        public PaintGallon(float area) : base(area) { }

        public int CalculateAmount()
        {
            var gallonsRequired = (int)Math.Ceiling(LitersRequired() / _gallonSize);

            return gallonsRequired;
        }

        public float CalculatePrice()
        {
            return _unitPrice * CalculateAmount();
        }
    }
}
