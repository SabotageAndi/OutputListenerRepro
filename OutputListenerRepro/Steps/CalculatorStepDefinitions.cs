using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace OutputListenerRepro.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext, ISpecFlowOutputHelper specFlowOutputHelper)
        {
            _scenarioContext = scenarioContext;
            _specFlowOutputHelper = specFlowOutputHelper;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           _specFlowOutputHelper.WriteLine("test");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
           
        }
    }
}
