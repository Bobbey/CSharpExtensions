using System;
using System.Text.RegularExpressions;

namespace BobbeyExtensions
{
    public static class Intervals
    {
        /// <summary>
        /// Determins if an Integer is within the given range which includes its defining borders.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="limit1"></param>
        /// <param name="limit2"></param>
        /// <returns></returns>
        public static bool IsInClosedInterval(this int number, int limit1, int limit2)
        {            
            int upperlimit = limit2;
            int lowerlimit = limit1;

            if (limit1 > limit2)
            {
                upperlimit = limit1;
                lowerlimit = limit2;
            }
            

            if (number > upperlimit || number < lowerlimit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determins if an Integer is within the given range which excludes its defining borders.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="limit1"></param>
        /// <param name="limit2"></param>
        /// <returns></returns>
        public static bool IsInOpenInterval(this int number, int limit1, int limit2)
        {

            int upperlimit = limit2;
            int lowerlimit = limit1;

            if (limit1 > limit2)
            {
                upperlimit = limit1;
                lowerlimit = limit2;
            }


            if (number >= upperlimit || number <= lowerlimit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Determins if the given Integer is contained by the defined interval.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="interval">Well defined interval as specified in ISO 31-11</param>
        /// <returns>bool isInInterval</returns>
        public static bool IsInInterval(this int number, string interval)
        {

            var x = Regex.Match(interval, @"(\[|\()(\d+)\,(\d+)(\)|\])");

            if (!x.Success)
            {
                throw new ArgumentException("given string is not a well formed interval as specified in ISO 31-11.", nameof(interval));
            }

            bool isTopOpen = x.Groups[4].Value != "]";
            bool IsBottomOpen = x.Groups[1].Value != "[";


            int lowerLimit = int.Parse(x.Groups[2].Value);
            int upperLimit = int.Parse(x.Groups[3].Value);

            if (upperLimit < lowerLimit)
            {
                throw new ArgumentException("given string is not well formed as specified in ISO 31-11. Check the order of your Parameters, try to switch them.", nameof(interval));
            }


            if (IsBottomOpen)
            {
                if (number <= lowerLimit)
                {
                    return false;
                }
            } else {

                if (number < lowerLimit)
                {
                    return false;
                }
            }

            if (isTopOpen)
            {
                if (number >= upperLimit)
                {
                    return false;
                }
            }
            else
            {
                if (number > upperLimit)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
