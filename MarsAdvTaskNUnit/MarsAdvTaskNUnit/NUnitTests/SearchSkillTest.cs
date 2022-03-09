using AventStack.ExtentReports;
using MarsAdvTaskNUnit.Pages;
using MarsAdvTaskNUnit.Utils;
using NUnit.Framework;

namespace MarsAdvTaskNUnit.NUnitTests
{
    [TestFixture]
    class SearchSkillTest : CommonDriver
    {
        [Test, Order(1), Category("Search Skill")]
        public void SearchSkillTest1()
        {
            test = extent.CreateTest("Validate Search Skill using Category");
            test.Log(Status.Info, "Browser Initialisation");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);

            // Search Skill object initialization and definition
            SearchSkill searchSkillObj = new SearchSkill(testDriver);
            searchSkillObj.SearchSkillCategory();

            TestContext.WriteLine(searchSkillObj);
        }

        [Test, Order(2), Category("Search Skill")]
        public void SearchSkillSubTest()
        {
            test = extent.CreateTest("Validate Search Skill using Sub Category");
            test.Log(Status.Info, "Browser Initialisation");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);

            // Search Skill object initialization and definition
            SearchSkill searchSkillObj = new SearchSkill(testDriver);
            searchSkillObj.SearchSkillSubCategory();

            TestContext.WriteLine(searchSkillObj);
        }
    }
}
