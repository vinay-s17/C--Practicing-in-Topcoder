using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRadarTopCoder
{
    class SpeedRadar
    {
        static void Main(string[] args)
        {
            int minLimit = 20;
            int maxLimit = 60;
            double average = 0;
            int[] readings = { 25, 45, 45, 43, 24, 9, 51, 55, 60, 34, 61, 23, 40, 40, 47, 49, 33, 23, 47, 54, 54 };
            SpeedRadar obj=new SpeedRadar();
            average=obj.averageSpeed(minLimit, maxLimit, readings);
            Console.WriteLine(average);
        }

        public double averageSpeed(int minLimit, int maxLimit, int[] readings)
        {
            double avareage = 0, count=0,sum = 0,percent=0;
            for (int i = 0; i < readings.Length; i++)
            {
                if(readings[i]>maxLimit || readings[i]<minLimit)
                {
                    count++;
                }
                else
                {
                    sum = sum + readings[i];
                }
            }
            percent = (count*100)/readings.Length;
            if (percent <= 10)
            {
                avareage = sum / (readings.Length - count);
            }
            
            return avareage;
        }

    }
}
