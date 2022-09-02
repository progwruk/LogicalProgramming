using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatch
    {
        int st;
        public void ElapsedTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("To stop the program press 1", st);
            st = Convert.ToInt32(Console.ReadLine());
            if (st == 1)
            {
                Console.WriteLine("Stop");
                stopWatch.Stop();
            }
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine("Time: {0}:{1}:{2}:{3}", timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
        }
    }
}
