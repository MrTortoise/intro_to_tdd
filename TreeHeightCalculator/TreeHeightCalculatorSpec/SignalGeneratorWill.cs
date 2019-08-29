using System.Collections.Generic;
using System.Linq;
using Xunit;
using static System.Int32;

namespace TreeHeightCalculatorSpec
{
    public class SignalGeneratorWill
    {
        private readonly SignalGenerator _signalGenerator;
        private readonly List<string> _testData;

        public SignalGeneratorWill()
        {
            _testData = new List<string>()
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

            _signalGenerator = new SignalGenerator();
        }

        [Fact]
        public void ProduceTheRightSetOfData()
        {
            Assert.Equal(_testData, _signalGenerator.GetInput());
        }

        [Fact]
        public void Produce22Items()
        {
            Assert.Equal(22, _signalGenerator.GetInput().Count());
        }

        [Fact]
        public void TestDataContains20Numbers()
        {
            Assert.Equal(20, _signalGenerator.GetInput().Count(n => TryParse(n, out _)));
        }
    }
}
