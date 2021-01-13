using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Model
{
    public class Angle
    {
        public int Grad { get; }
        public int Min { get; }
        public int Sec { get; }

        public Angle(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public Angle(Decimal grad, Decimal min, Decimal sec)
        {
            Grad = Decimal.ToInt32(grad);
            Min = Decimal.ToInt32(min);
            Sec = Decimal.ToInt32(sec);
        }
    }
}
