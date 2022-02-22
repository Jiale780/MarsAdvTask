using AventStack.ExtentReports;
using MarsAdvTaskNUnit.Pages;
using MarsAdvTaskNUnit.Utils;
using NUnit.Framework;

namespace MarsAdvTaskNUnit.NUnitTests
{
    [TestFixture]
    class LoginTest : CommonDriver
    {
        [Test, Category("Login")]
        public void LoginPageTest()
        {
            test = extent.CreateTest("Login");
            test.Log(Status.Info, "User System Login");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);
            TestContext.WriteLine(loginPageObj);
        }
    }
}
