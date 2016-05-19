using TechTalk.SpecFlow;
using CalculatorExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProjectSpecFlow
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();
        private double Result { get; set; }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = calculator.Add();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            Result = calculator.Multiply();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            Assert.AreEqual(expected, Result);
        }
    }
}
