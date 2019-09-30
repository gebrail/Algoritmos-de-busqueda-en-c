using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Operaciones
{
    class Mergesort
    {

        int h=Form1.xd;

        int[] vectorA=Form1.vectorA;

        int[] vectorB = Form1.vectorB;

        public void merge_sort(int left,int right, int [] vectorA, int[] vectorB)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int mind;

            if (right > left)
            {
                mind = (right + left) / 2;
                merge_sort(left, mind, vectorA, vectorB);
                merge_sort(mind+1,right, vectorA, vectorB);
                merge(left,mind+1,right);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
            Form1.tiempoc = ts.ToString();

        }

        public void merge(int left,int mind, int right)
        {
            int i, left_end, num_elementos, tmp_pos;

            left_end = mind - 1;

            tmp_pos = left;

            num_elementos = right - left + 1;

            while (left<=left_end && mind<=right)            
            {

                if (vectorA[left]<=vectorA[mind])
                {

                    vectorB[tmp_pos] = vectorA[left];

                    tmp_pos = tmp_pos + 1;

                    left = left + 1;
                        
                }
                else 
                {

                    vectorB[tmp_pos] = vectorA[mind];
                    
                    tmp_pos = tmp_pos + 1;
                    
                    mind = mind + 1;

                
                
                }

            
            }

            while (left<=left_end) 

            {

                vectorB[tmp_pos] = vectorA[left];
                
                left = left + 1;

                tmp_pos = tmp_pos + 1;



            }


            while (mind <= right)

            {

                vectorB[tmp_pos] = vectorA[mind];

                mind= mind + 1;

                tmp_pos = tmp_pos + 1;

            }

            for (int h = 0; h < num_elementos; h++)
            {
                vectorA[right] = vectorB[right];

                right = right - 1;

            }




        }


    }
}
