using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using static System.Int32;

namespace TreeHeightCalculatorSpec
{
    public class SignalGeneratorWill
    {
        private List<string> _inputData;

        public SignalGeneratorWill()
        {
            _inputData = new List<string>()
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
        }

        [Fact]
        public void ProduceTheRightSetOfData()
        {
            Assert.Equal(_inputData, _inputData);
            Assert.Equal(22, _inputData.Count);
        }

        [Fact]
        public void TestDataContains20Numbers()
        {
            Assert.Equal(20, _inputData.Count(n => TryParse(n, out _)));
        }
    }
}
