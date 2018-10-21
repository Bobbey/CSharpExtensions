﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BobbeyExtensions
{
    public static class DiceMachine
    {
        /// <summary>
        /// Maps results to probabilities and executes a random experiment
        /// </summary>
        /// <param name="results"></param>
        /// <param name="probabilities"></param>
        /// <param name="rng"></param>
        /// <returns></returns>
        public static T ExecuteRandomExperiment<T>(this IList<T> results, IList<double> probabilities, Random rng)
        {

            if (results.Count != probabilities.Count)
            {
                throw new ArgumentException("Make sure given Lists are equal in length.");
            }

            List<string> intervals = new List<string>();

            double sum = 0;
            foreach (float p in probabilities)
            {
                double nextsum = sum + p;
                //string lowerLimit = 

                intervals.Add($"[ {sum.ToString("G",CultureInfo.InvariantCulture)} , {nextsum.ToString("G",CultureInfo.InvariantCulture)})");
                sum = nextsum;
            }

            if (sum > 1)
            {
                throw new ArgumentException("Your probabilities should sum up to 1.");
            }



            for (int i = 0; i < intervals.Count; i++)
            {
                if (rng.NextDouble().IsInInterval(intervals[i]))
                {
                    return results[i];
                }
            }

            return default(T);
        }
    }
}