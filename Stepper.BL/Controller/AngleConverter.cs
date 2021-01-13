using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stepper.BL.Model;

namespace Stepper.BL.Controller
{
    /// <summary>
    /// Перевод углов
    /// </summary>
    public class AngleConverter
    {
        private const double CONVERT_CONST = 0.8091;

        /// <summary>
        /// Перевод угла в код
        /// </summary>
        /// <param name="angle">Угол</param>
        /// <param name="dir">Направление.</param>
        /// <returns>int</returns>
        public int AngleToCode(Angle angle, bool dir)
        {
            int sec = angle.Grad * 3600 + angle.Min * 60 + angle.Sec;
            int code = (int)(sec * CONVERT_CONST);

            if(!dir)
            {
                code = UInt16.MaxValue - code;
            }

            return code;
        }

        /// <summary>
        /// Перевод из кода в угол.
        /// </summary>
        /// <param name="code">Код угла.</param>
        /// <param name="dir">Направление.</param>
        /// <returns>Angle</returns>
        public Angle CodeToAngle(int code, bool dir)
        {
            if(!dir)
            {
                code = UInt16.MaxValue - code;
            }
            int s = (int)(code / CONVERT_CONST);
            int grad = s / 3600;
            int min = (s % 3600) / 60;
            int seс = (s % 3600) % 60;
            Angle angle = new Angle(grad, min, seс);
            return angle;
        }

            

    }
}
