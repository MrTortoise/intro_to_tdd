using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TreeHeightCalculatorSpec
{
    public class SignalGeneratorWill
    {
        [Fact]
        public void ProduceTheRightSetOfData()
        {
            var expectedresults = new List<string>()
            {
                "1",
                "2",
                "3",
                "connifer",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "fungus",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20"
            };

            Assert.Equal(expectedresults, expectedresults);
            Assert.Equal(22, expectedresults.Count);
        }
    }
}
