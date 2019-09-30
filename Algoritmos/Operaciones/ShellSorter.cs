using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algoritmos.Operaciones
{
    class ShellSorter
    {

        public void Sort(int[] list)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Thread.Sleep(10000);
            int j, inc;
            inc = list.Length / 2;

            while (inc >= 1)
            {
                for (int i = inc; i < list.Length; i++)
                {
                    int v = list[i];

                    j = i - inc;

                    while (j >= 0 && list[j] > v)
                    {
                        list[j + inc] = list[j];
                        j = j - inc;
                    }
                    list[j + inc] = v;

                }
                inc = inc / 2;

            }


            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
            Form1.tiempo = ts.ToString();

        }


    }
}
