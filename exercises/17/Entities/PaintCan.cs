using System;
using System.Collections.Generic;
using System.Text;

namespace _17.Entities
{
    class ICalculateNoWastePaintCan
    {
        public int cansRequired;
        public float missingArea;
        public float cansPrice;
    }

    class PaintCan : Paint
    {
        private readonly float _canSize = 18F;
        private readonly float _unitPrice = 80F;

        public PaintCan(float area) : base(area) { }

        public int CalculateAmount()
        {
            var cansRequired = (int)Math.Ceiling(LitersRequired() / _canSize);

            return cansRequired;
        }

        public ICalculateNoWastePaintCan CalculateNoWaste()
        {
            var cansRequired = (int)Math.Floor(LitersRequired() / _canSize);
            var missingArea = Area - (cansRequired * _canSize / _paintRate);
            var cansPrice = cansRequired * _unitPrice;

            var result = new ICalculateNoWastePaintCan
            {
                cansRequired = cansRequired,
                missingArea = missingArea,
                cansPrice = cansPrice
            };

            return result;
        }

        public float CalculatePrice()
        {
            return _unitPrice * CalculateAmount();
        }
    }
}
