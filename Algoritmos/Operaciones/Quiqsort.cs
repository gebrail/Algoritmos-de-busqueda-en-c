using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Operaciones
{
    class Quiqsort
    {


        public int[] quicksortxd(int [] vector,int primero,int ultimo)        
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int i, j, central;

            double pivote;

            central = (primero+ultimo) / 2;

            pivote = vector[central];

            i = primero;
            j = ultimo;

            do
            {
                while (vector[i] < pivote) i++;

                while (vector[j] > pivote) j--;

                if (i <= j)
                {

                    int temp;

                    temp = vector[i];

                    vector[i] = vector[j];

                    vector[j] = temp;

                    i++;

                    j--;

                }

            }

            while (i <= j);
            {
                if (primero < j) 
                {
                    quicksortxd(vector, primero, j);
                
                }
                if (i<ultimo)
                {
                    quicksortxd(vector, i, ultimo);
                }


            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
            Form1.tiempob = ts.ToString();

            return vector;
        
        }


    }
}
