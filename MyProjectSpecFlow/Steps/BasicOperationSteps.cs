using System;
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
        public void GivenIHaveEnteredIntoTheCalculator(string number)
        {
            calculator.FirstNumber = double.Parse(number);
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(string number)
        {
            calculator.SecondNumber = double.Parse(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Result = calculator.Add();
            ScenarioContext.Current["InfoForNextStep"] = "Step1 Passed";
            Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            Result = calculator.Multiply();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expected)
        {
            Assert.AreEqual(double.Parse(expected), Result);
        }
    }
}
