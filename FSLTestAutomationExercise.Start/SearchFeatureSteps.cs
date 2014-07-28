using System;
using TechTalk.SpecFlow;

namespace FSLTestAutomationExercise.Start
{
    [Binding]
    public class SearchFeatureSteps
    {
        [Given(@"I have navigated to '(.*)' in my web browser")]
        public void GivenIHaveNavigatedToInMyWebBrowser(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered '(.*)' into the search box")]
        public void GivenIHaveEnteredIntoTheSearchBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on '(.*)'")]
        public void WhenIClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on '(.*)'m feeling lucky'")]
        public void WhenIClickOnMFeelingLucky(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am presented with a list of results")]
        public void ThenIAmPresentedWithAListOfResults()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"'(.*)' is the first result")]
        public void ThenIsTheFirstResult(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"'(.*)' is the fifth result")]
        public void ThenIsTheFifthResult(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am automatically redirected to '(.*)' in my web browser")]
        public void ThenIAmAutomaticallyRedirectedToInMyWebBrowser(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
