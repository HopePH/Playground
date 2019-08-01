using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace SpecFlowPractice
{
    [Binding]
    class SpecFlowFeatureSteps
    {
        public Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string number)
            => calculator.FirstNumber = number;

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(string number)
            => calculator.SecondNumber = number;

        [When(@"I press add")]
        public void WhenIPressAdd()
            => calculator.Add();

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expectedResult)
        {
            var eResult = expectedResult.Replace("\"", "");
            Assert.AreEqual(int.Parse(eResult), calculator.Result);
        }

        [Given(@"I'm in the console app")]
        public void GivenIMInTheConsoleApp()
        {
         //do nothing... 
        }

        //[When(@"I entered ""(.*)"" character")]
        //public void WhenIEnteredCharacter(string number)
        //    => calculator.FirstNumber = number;

        [Then(@"I will show a message that saying ""(.*)""")]
        public void ThenIWillShowAMessageThatSaying(string message)
            => Assert.AreEqual(calculator.Message, message);

        [When(@"I entered ""(.*)"" and second no ""(.*)"" into the calculator and add it")]
        public void WhenIEnteredAndSecondNoIntoTheCalculator(string num1, string num2)
        {
            calculator.FirstNumber = num1;
            calculator.SecondNumber = num2;
            calculator.Add();
        }
    }
}
