using AventStack.ExtentReports;
using MarsAdvTaskNUnit.Pages;
using MarsAdvTaskNUnit.Pages.Profile;
using MarsAdvTaskNUnit.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsAdvTaskNUnit.NUnitTests.Profile
{
    [TestFixture]
    class ProfileEducationTest : CommonDriver
    {
        [Test, Order(1), Category("Education")]
        public void AddProfileTest()
        {
            test = extent.CreateTest("Add Education");
            test.Log(Status.Info, "Browser Initialisation");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);

            // Home Page object initialization and definition
            HomePage homePgObj = new HomePage();
            homePgObj.EducationPage(testDriver);

            // Profile Education Page object initialization and definition
            ProfileEducation ProfileEducationObj = new ProfileEducation(testDriver);
            ProfileEducationObj.AddNewEducationBtn(testDriver);
            ProfileEducationObj.AddEducation(testDriver);
            ProfileEducationObj.ValidateAddEducationDetails(testDriver);
            test.Log(Status.Info, "The education has been added successfully");
            TestContext.WriteLine(ProfileEducationObj);
        }

        [Test, Order(2), Category("Education")]
        public void EditProfileTest()
        {
            test = extent.CreateTest("Edit Education");
            test.Log(Status.Info, "Browser Initialisation");

            // Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage(testDriver);
            loginPageObj.LoginSteps(testDriver);

            // Home Page object initialization and definition
            HomePage homePgObj = new HomePage();
            homePgObj.EducationPage(testDriver);

            // Profile Education Page object initialization and definition
            ProfileEducation ProfileEducationObj = new ProfileEducation(testDriver);
            ProfileEducationObj.EditEducationBtn(testDriver);
            ProfileEducationObj.EditEducation(testDriver);
            ProfileEducationObj.ValidateEditEducationDetails(testDriver);
            test.Log(Status.Info, "The education has been updated successfully");
            TestContext.WriteLine(ProfileEducationObj);
        }


    }
}
