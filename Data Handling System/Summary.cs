using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Handling_System
{
    class Summary
    {
        public static int FindMin(List<string> value)
        {
            var minValue = Convert.ToInt16(value.ElementAt(0));
            for (int i = 0; i < value.Count; i++)
            {
                minValue = (minValue > Convert.ToInt16(value.ElementAt(i))) ? Convert.ToInt16(value.ElementAt(i)) : minValue;
            }
            return minValue;
        }

        public static int FindMax(List<string> value)
        {
            int maxValue = 0;
            for (int i = 0; i < value.Count; i++)
            {
                maxValue = (maxValue > Convert.ToInt16(value.ElementAt(i))) ? maxValue : Convert.ToInt16(value.ElementAt(i));
            }
            return maxValue;
        }
        public static int FindSum(List<string> list)
        {
            int sum = 0;
            foreach (var data in list)
            {
                sum += sum + Convert.ToInt16(data);
            }
            return sum;
        }
        public static double FindAverage(List<string> value)
        {
            double average = 0;
            foreach (var data in value)
            {
                average += average + Convert.ToDouble(data);
            }
            return average;
        }
    }
}