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

        public int CodeToSteps(int newCode, int microStep, int currentPosCode, int koefRedduction)
        {

            int codeToMove = 0;
            if (currentPosCode < 31000) // находимся в положительной позиции 
            {
                if (newCode < 31000) // задан положительный угол
                {
                    codeToMove = Math.Abs(newCode - currentPosCode);
                }
                else // задан отрицательный угол
                {
                    codeToMove = currentPosCode + newCode;
                    codeToMove = UInt16.MaxValue - codeToMove;
                }
            }
            else // находимся в отрицательном положении
            {
                if (newCode > 31000)    // задан отрицательный угол
                    codeToMove = Math.Abs(newCode - currentPosCode);
                else // задан положительный угол
                    codeToMove = (UInt16.MaxValue - currentPosCode) + newCode;
            }
            double sec = Math.Ceiling(codeToMove / CONVERT_CONST);
            int steps = (int)Math.Ceiling(sec / (6480 / koefRedduction / microStep)); 
            return steps;
        }
    }
}
