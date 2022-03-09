using AventStack.ExtentReports;
using MarsAdvTaskNUnit.Pages;
using MarsAdvTaskNUnit.Utils;
using NUnit.Framework;

namespace MarsAdvTaskNUnit.NUnitTests
{
    [TestFixture]
    class ChatTest : CommonDriver
    {
        [Test, Order(1), Description("Navigate to the chat history page")]
        public void NavigateChatHistory()
        {
            test = extent.CreateTest("Navigate to the chat history page");
            test.Log(Status.Info, "Browser Initialisation");
            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);

            loginPageObj.LoginSteps(testDriver);
            TestContext.WriteLine(loginPageObj);

            // Chat History object initialization and definition
            ChatPage ChatPageObj = new ChatPage(testDriver);
            ChatPageObj.ChatHistoryList();
        }
    }
}
