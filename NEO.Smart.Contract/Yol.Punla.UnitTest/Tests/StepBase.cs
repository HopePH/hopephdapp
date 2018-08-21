using TechTalk.SpecFlow;

namespace Yol.Punla.UnitTest.Tests
{
    public class StepBase
    {
        protected readonly ScenarioContext _scenarioContext;

        public StepBase(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }
    }
}
