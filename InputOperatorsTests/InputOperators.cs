using Microsoft.VisualStudio.TestTools.UnitTesting;
using input = InputOperators;

namespace InputOperatorsTests
{
    [TestClass]
    public class InputOperators
    {
        [TestMethod]
        public void DuplicateCheck()
        {

            string inputText = "I like to eat apple";
            string operation = "1";

            input.InputOperators.DuplicateCheck(inputText.ToLower().ToCharArray(), operation);

            inputText = "I adore Pulk";

            input.InputOperators.DuplicateCheck(inputText.ToLower().ToCharArray(), operation);

        }

        [TestMethod]
        public void VowelsCount()
        {
            string inputText = "I like to eat apple";
            string operation = "2";

            input.InputOperators.VowelsCount(inputText.ToLower().ToCharArray(), operation);

            inputText = "Smrž pln skvrn zvlhl z mlh";

            input.InputOperators.VowelsCount(inputText.ToLower().ToCharArray(), operation);

        }

        [TestMethod]
        public void VowelsCountCompare()
        {

            string inputText = "I like apples";
            string operation = "3";

            input.InputOperators.VowelsCountCompare(inputText.ToLower(), operation);

            inputText = "I ate";

            input.InputOperators.VowelsCountCompare(inputText.ToLower(), operation);

            inputText = "Food is nice";

            input.InputOperators.VowelsCountCompare(inputText.ToLower(), operation);

        }
    }
}