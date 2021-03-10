using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stepper.BL.Controller;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Stepper.BL.Model;

namespace Stepper.BL.Controller
{
    public class ChartController
    {
        /// <summary>
        /// Время измерений в секундах.
        /// </summary>
        private int time;
        /// <summary>
        /// Частота приёма данных в герцах
        /// </summary>
        private double freqHz;
        int ms;
        /// <summary>
        /// Контроллер отображения данных на графиках
        /// </summary>
        /// <param name="time"></param>
        /// <param name="freqHz"></param>
        AxisCharts axisCharts;//= new AxisCharts(10, DateTime.Now, DateTime.Now);


        public ChartController(int time, double freqHz)
        {
            this.time = time;
            this.freqHz = freqHz;
            int length = CalculateLength(time, freqHz);
            ms = (int)(1000 / freqHz);
            DateTime currentTime = DateTime.Today;
            DateTime timeEnd= currentTime.AddMilliseconds(CalculateEndTime(length, freqHz));

            axisCharts = new AxisCharts(length, currentTime, timeEnd);
            
        }
        public void UpdateChartsData( ushort dataX, ushort dataY,  ushort dataZ )
        {
            axisCharts.XaxisData[axisCharts.Length - 1] = dataX;
            axisCharts.YaxisData[axisCharts.Length - 1] = dataY;
            axisCharts.ZaxisData[axisCharts.Length - 1] = dataZ;

            Array.Copy(axisCharts.XaxisData, 1, axisCharts.XaxisData, 0, axisCharts.Length - 1);
            Array.Copy(axisCharts.YaxisData, 1, axisCharts.YaxisData, 0, axisCharts.Length - 1);
            Array.Copy(axisCharts.ZaxisData, 1, axisCharts.ZaxisData, 0, axisCharts.Length - 1);
        }
        public void ShowCharts(Chart chartX, double dataX, Chart chartY, double dataY, Chart chartZ, double dataZ)
        {
            chartX.Series[0].Points.AddY(dataX);
            chartY.Series[0].Points.AddY(dataY);
            chartZ.Series[0].Points.AddY(dataZ);

            if(chartY.Series[0].Points.Count > axisCharts.Length)
            {
                chartX.Series[0].Points.RemoveAt(0);
                chartY.Series[0].Points.RemoveAt(0);
                chartZ.Series[0].Points.RemoveAt(0);
            }
        }

        public void UpdateTime()
        {
            axisCharts.TimeStart =  axisCharts.TimeStart.AddMilliseconds(ms);
            axisCharts.TimeEnd = axisCharts.TimeEnd.AddMilliseconds(ms);
        }

        public void ShowTime(Label start, Label end)
        {
            start.Text = axisCharts.TimeStart.ToString("m:ss:f");
            end.Text = axisCharts.TimeEnd.ToString("m:ss:f");
        }



        /// <summary>
        /// Считает количество длину массива данных в зависимости от частоты дескритизации и промежутка времени измерения.
        /// </summary>
        /// <param name="time">Промежуток времени измерения.</param>
        /// <param name="freqHz">Частота дискертизации.</param>
        /// <returns></returns>
        private int CalculateLength(int time, double freqHz)
        {
            return  (int)(time * freqHz);
        }
        private int CalculateEndTime(int length, double freqHz)
        {
            int ms = (int)(1000 / freqHz);
            return (int)(time * freqHz * ms);
        }
    }
}
