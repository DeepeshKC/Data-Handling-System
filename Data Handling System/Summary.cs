using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Handling_System
{
    class Summary
    {
        /// <summary>
        /// converts date into corrected format
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConvertToDate(string date)
        {
            string year = "";
            string month = "";
            string day = "";

            for (int i = 0; i < 4; i++)
            {
                year = year + date[i];
            };

            for (int i = 4; i < 6; i++)
            {
                month = month + date[i];
            };

            for (int i = 6; i < 8; i++)
            {
                day = day + date[i];
            };

            string convertedDate = year + "-" + month + "-" + day;

            return convertedDate;
        }

        //Calculates average speed
        public static string FinDAverageSpeed(List<string> value)
        {

            double total = 0; ;
            int counter = 0;
            double averageSpeed = 0;
            foreach (var val in value)
            {
                total = total + Convert.ToInt32(value[counter]);
                counter++;

            }

            averageSpeed = total / counter;
            double average1 = System.Math.Round(averageSpeed, 2);
            return average1.ToString();
        }

        // maximum speed
        public static string FindMaxSpeed(List<string> value)
        {

            double speedd = Convert.ToInt32(value.Max());


            return +speedd + " km/hr";
        }

        /// <summary>
        /// calculate the sum of an array
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static double FindSum(List<string> list)
        {
            double sum = 0;

            foreach (var data in list)
            {
                sum += Convert.ToDouble(data);
            }

            return sum;
        }

        /// <summary>
        /// rounds the double value uptp nth position
        /// </summary>
        /// <param name="input"></param>
        /// <param name="places"></param>
        /// <returns></returns>
        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

        //Calculates and returns average heart rate
        public static string FindAverageHeartRate(List<string> value)
        {

            int total = 0;
            int counter = 0;
            double averageRate = 0.00;
            foreach (var val in value)
            {
                total = total + Convert.ToInt32(value[counter]);
                counter++;

            }

            averageRate = total / counter;
            double distance1 = System.Math.Round(averageRate, 2);
            return +distance1 + " bpm";

        }

        //Calculates and returns minimum heart rate
        public static string FindMinHeartRate(List<string> value)
        {

            int heartRate = Convert.ToInt32(value[0]);

            int minHeartRate = Convert.ToInt32(value.Min());

            return +minHeartRate + " bpm";
        }

        //Calculates and returns maximum heart rate
        public static string FindMaxHeartRate(List<string> value)
        {

            int heartRate = Convert.ToInt32(value.Max());


            return +heartRate + " bpm";
        }

        /// <summary>
        /// finds average of array's value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double FindAverage(List<string> value)
        {
            int average = 0;

            foreach (var data in value)
            {
                average += Convert.ToInt16(data);
            }

            return average / value.Count;
        }


        //Calculates Average power
        public static string FindAveragePower(List<string> value)
        {

            int total = 0; ;
            int counter = 0;
            double averagePower = 0;
            foreach (var val in value)
            {
                total = total + Convert.ToInt32(value[counter]);
                counter++;

            }

            averagePower = total / counter;
            double power1 = System.Math.Round(averagePower, 2);
            return +power1 + "watts";
        }

        //Calculating  maximum power
        public static string FindMaxPower(List<string> value)
        {


            int maxPow = Convert.ToInt32(value.Max());

            return +maxPow + " watts";
        }

        //Calculating  average altitude
        public static string FindAverageAltitude(List<string> value)
        {

            int total = 0;
            int counter = 0;
            double averageAltitude = 0;
            foreach (var val in value)
            {
                total = total + Convert.ToInt32(value[counter]);
                counter++;

            }

            averageAltitude = total / counter;
            double alt = System.Math.Round(averageAltitude, 2);
            return +alt + " m/ft";
        }

    }
}
