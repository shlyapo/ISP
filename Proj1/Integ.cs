using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Proj1
{
    public class Int
    {
        public delegate void result(double res);
        public event result Result;

        public void Integ()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double step = 0.00000001;
            double sum = 0;
            double y;
            for (double x = step / 2; x < 1; x += step)
            {
                y = Math.Sin(x);
                sum += y;
            }
            sum *= step;
            Result?.Invoke(sum);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

        }
        public void InfRes(double result)
        {
            Console.WriteLine(result);
        }

    }
}
