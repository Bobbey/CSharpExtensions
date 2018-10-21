using System;

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


    }
}
