using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowPractice
{
    [Binding]
    class SpecFlowFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("I pressed add.");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
            {
                Console.WriteLine("The test PASSED");
            }
            else
            {
                Console.WriteLine("The test FAILED");
                throw new Exception("The value is different!");
            }
                
        }

    }
}
