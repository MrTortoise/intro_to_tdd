using System.Collections.Generic;

namespace TreeHeightCalculatorSpec
{
    public class SignalGenerator
    {
        private readonly List<string> _inputData;

        public SignalGenerator()
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

        public IEnumerable<string> GetInput()
        {
            foreach (var val in _inputData)
            {
                yield return val;
            }
        }
    }
}