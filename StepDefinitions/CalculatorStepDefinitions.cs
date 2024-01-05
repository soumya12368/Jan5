using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Assignmnet1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private int num1, num2, result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            if (num1 == 0)
                num1 = number;
            else
                num2 = number;
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = num1 * num2;
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            result = num1 - num2;
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = num1 / num2;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}