using System;
using TechTalk.SpecFlow;

namespace TFLAPITestAutomation.StepDefinitions
{
    [Binding]
    public class UserManageSteps
    {
        [Given(@"post request to create user with name '(.*)' and job '(.*)' is sent")]
        public void GivenPostRequestToCreateUserWithNameAndJobIsSent(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"GET request to create user with firstname '(.*)' and lastname '(.*)' is sent")]
        public void GivenGETRequestToCreateUserWithFirstnameAndLastnameIsSent(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"put request to update user with name '(.*)' and job '(.*)' is sent")]
        public void GivenPutRequestToUpdateUserWithNameAndJobIsSent(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"GET request to create user with blankfirstname '(.*)' and blank lastname '(.*)' is sent")]
        public void GivenGETRequestToCreateUserWithBlankfirstnameAndBlankLastnameIsSent(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"created details should be")]
        public void ThenCreatedDetailsShouldBe(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
