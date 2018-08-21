using Hello.Contract;
using TechTalk.SpecFlow;
using Yol.Punla.UnitTest.Tests;
using Should;

namespace Yol.Punla.UnitTest
{
    [Binding]
    public class HelloContractSteps : StepBase
    {
        private SmartLogic smartLogic = null;

        public HelloContractSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When(@"I execute the Hello World Smart Contract")]
        public void WhenIExecuteTheHelloWorldSmartContract()
        {
            smartLogic = new SmartLogic();
        }
        
        [Then(@"I should see that the smart contract execute without errors")]
        public void ThenIShouldSeeThatTheSmartContractExecuteWithoutErrors()
        {
            smartLogic.Success.ShouldBeTrue();
        }
    }
}
