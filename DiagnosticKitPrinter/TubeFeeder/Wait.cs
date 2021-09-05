using System;
using System.Diagnostics;
using System.Threading;

namespace TubeFeeder
{
    public class Wait
    {
        private static bool isHighResolution;
        private static long frequency;
        private ManualResetEvent re;
        private Stopwatch sw;
        private long ticks;
        private long finalTicks;


        static Wait()
        {
            isHighResolution = Stopwatch.IsHighResolution;
            frequency = Stopwatch.Frequency;
        }

        protected Wait(long microseconds)
        {
            re = new ManualResetEvent(false);

            sw = Stopwatch.StartNew();

            if (isHighResolution == false)
                throw new NotSupportHighResolutionException("System is not support high resolution frequency.");

            ticks = microseconds * frequency / 1000000;
        }

        public static Wait Start(long microseconds)
        {
            Wait result = new Wait(microseconds);
            return result;
        }

        public void Sleep()
        {
            while (sw.ElapsedTicks <= ticks)
                ;// Thread.SpinWait(100);
            //Thread.Sleep(1);
            //re.WaitOne(1);

            finalTicks = sw.ElapsedTicks;
        }

        public long TotalMicroseconds
        {
            get
            {
                return finalTicks * 1000000 / frequency;
            }
        }
    }

    public class NotSupportHighResolutionException : Exception
    {
        public NotSupportHighResolutionException(string msg)
            : base(msg)
        {
        }
    }
}
