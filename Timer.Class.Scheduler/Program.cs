using System;
using System.Timers;

namespace SchedulerWithTimer
{
    class Program
    {
        static Timer _timer = new Timer(1000);
        static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Timer starts!");
            _timer.Elapsed += _timer_Elapsed;
            _timer.Enabled = true;
            _timer.AutoReset = true;
            _timer.Start();
            Console.ReadKey();
        }

        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(++count + " seconds");
        }
    }
}
