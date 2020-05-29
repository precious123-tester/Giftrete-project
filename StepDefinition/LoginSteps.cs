using GIFTRETEPROJECT.PageObject;
using System;
using TechTalk.SpecFlow;

namespace GIFTRETEPROJECT.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;
        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [Given(@"I click on login")]
        public void GivenIClickOnLogin()
        {
            loginPage.ClickLogin();
        }


        [Given(@"I enter my emailaddress")]
        public void GivenIEnterMyEmailaddress()
        {
            loginPage.EnterEmailAddress();
        }

        [Given(@"I enter passwords")]
        public void GivenIEnterPasswords()
        {
            loginPage.EnterPassword();
        }

        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
           loginPage.Clicksignin();
        }
        
        [Then(@"I should be sign in")]
        public void ThenIShouldBeSignIn()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
