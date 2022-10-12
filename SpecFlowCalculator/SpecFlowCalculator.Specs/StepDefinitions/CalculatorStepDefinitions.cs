using FluentAssertions;

using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
            _result = 0;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Add();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber2(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Divide();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenOperation_IsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Subtract();
            _calculator.FirstNumber = _result;
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber3(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Mod();
            _calculator.FirstNumber = _result;
        }




        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}