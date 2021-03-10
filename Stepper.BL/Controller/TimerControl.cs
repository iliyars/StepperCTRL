using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stepper.BL.Controller
{
    public class TimerControl
    {
        private Timer _timer;

        public DateTime StartTime { set; get; }
        public TimeSpan CurrentElapsedTime { set; get; }
        public TimeSpan TotalElapsedTime { set; get; }

        public event EventHandler Tick;
        public bool isTimerRunning { get; set; }
        public string CurrentElapsedTimeStr { get; set; }

        public TimerControl()
        {

            StartTime = DateTime.MinValue;
            CurrentElapsedTime = TimeSpan.Zero;
            TotalElapsedTime = TimeSpan.Zero;
            _timer = new Timer();
            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;
            CurrentElapsedTimeStr = "";
            // Преобразование миллисекунд в десятые доли секунды.
            int tenths = elapsed.Milliseconds / 100;
            // Запишите оставшееся время.
            CurrentElapsedTimeStr += elapsed.Seconds.ToString("00") + "." +
                tenths.ToString("0");
            


            if (Tick != null) Tick(this, EventArgs.Empty);
        }

        public void StartTimer()
        {
            StartTime = DateTime.Now;
            TotalElapsedTime = CurrentElapsedTime;
            _timer.Start();
            isTimerRunning = true;
        }
        public void StopTimer()
        {
            _timer.Stop();
            isTimerRunning = false;
            TotalElapsedTime = TimeSpan.Zero;
            CurrentElapsedTime = TimeSpan.Zero;
        }
    }
}
