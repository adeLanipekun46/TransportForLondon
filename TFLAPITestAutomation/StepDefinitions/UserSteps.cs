using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TaskManagementAPITestAutomation.SetUp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TFLAPITestAutomation.Model;

namespace TFLAPITestAutomation.StepDefinitions
{
    [Binding]
    public class UserSteps
    {
        private Context _context;
        public UserSteps(Context context)
        {
            _context = context;
        }

        [Given(@"post request to create user with name '(.*)' and job '(.*)' is sent")]
        public void GivenPostRequestToCreateUserWithNameAndJobIsSent(string name, string job)
        {
            var user = new User();
            user.job = job;
            user.name = name;
            var userJson = JsonConvert.SerializeObject(user);
            _context.PostMethod("users", userJson);
        }

        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, _context.statusCode);
        }

        [Then(@"created details should be")]
        public void ThenCreatedDetailsShouldBe(Table table)
        {
            var expected = table.CreateInstance<User>().name;
            var actual = JObject.Parse(_context.content)["name"].ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
