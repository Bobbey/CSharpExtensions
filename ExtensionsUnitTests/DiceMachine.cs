using System;
using System.Collections.Generic;
using System.Text;
using Topology;
using Xunit;
using System.Linq;
using System.Diagnostics;

namespace ExtensionsUnitTests
{
    public class DiceMachine
    {

        [Fact(Skip = "For Debugging the DiceMachine")]
        public void PickWithSixtyPercentChanceOneOfThreeItems()
        {
            Random rng = new Random();
            double p = 0.2d;

            IList<string> strings = new string[]{ "first", "second", "third" };
            IList<double> probabilities = new double[] { p, p, p };

            string[] results = new string[100];

            for (int i = 0; i < 100; i++)
            {
                results[i] = strings.ExecuteRandomExperiment(probabilities, rng);
            }

            int[] measurements = new int[4];
            measurements[0] = results.Count(x => x == "first");
            measurements[1] = results.Count(x => x == "second");
            measurements[2] = results.Count(x => x == "third");
            measurements[3] = results.Count(x => x == null);           

            Debug.WriteLine($"times result first: {measurements[0]}");
            Debug.WriteLine($"times result second: {measurements[1]}");
            Debug.WriteLine($"times result third: {measurements[2]}");
            Debug.WriteLine($"times result null: {measurements[3]}");


            Assert.False(false);
        }

    }
}
