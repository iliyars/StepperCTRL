using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Model
{
    public class AxisCharts
    {
        /// <summary>
        /// Ось поворота Y.
        /// </summary>
        public double[] YaxisData { set; get; }
        /// <summary>
        /// Ось поаорота X.
        /// </summary>
        public double[] XaxisData { set; get; }
        /// <summary>
        /// Ось поворота Z.
        /// </summary>
        public double[] ZaxisData { set; get; }
        /// <summary>
        /// Левая граница времени измерений.
        /// </summary>
        public DateTime TimeStart { get; set; }
        /// <summary>
        /// Правая граница времени измерений.
        /// </summary>
        public DateTime TimeEnd { get; set; }
        public int Length { get;  }
        /// <summary>
        /// Создаёт класс для графиков.
        /// </summary>
        /// <param name="yaxisData"></param>
        /// <param name="xaxisData"></param>
        /// <param name="zaxisData"></param>
        /// <param name="timeStart"></param>
        /// <param name="timeEnd"></param>
        public AxisCharts(int length, DateTime timeStart, DateTime timeEnd)
        {
            Length = length;
            YaxisData = new double[Length];
            XaxisData = new double[Length];
            ZaxisData = new double[Length];
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }
    }
}
