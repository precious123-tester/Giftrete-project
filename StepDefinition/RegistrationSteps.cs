using GIFTRETEPROJECT.PageObject;
using System;
using TechTalk.SpecFlow;

namespace GIFTRETEPROJECT.StepDefinition
{
    [Binding]
    public class RegistrationStep
    {
        RegistrationPage registrationPage;
        public RegistrationStep()
        {
            registrationPage = new RegistrationPage();
        }
        [Given(@"Given I open a browser")]
        public void GivenGivenIOpenABrowser()
        {
          
        }
    
        [Given(@"I navigate to giftrete websit")]
        public void GivenINavigateToGiftreteWebsit()
        {
            registrationPage.NavigateToPage();
        }
        
        [Given(@"I click on create account")]
        public void GivenIClickOnCreateAccount()
        {
            registrationPage.ClickCreateAccount();
        }
        
        [Given(@"I enter first name")]
        public void GivenIEnterFirstName()
        {
            registrationPage.EnterFirstName();  
        }
        
        [Given(@"I enter last name")]
        public void GivenIEnterLastName()
        {
            registrationPage.EnterLastName();  
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmail(); 
        }
        
        [Given(@"I enter mobile number")]
        public void GivenIEnterMobileNumber()
        {
            registrationPage.EnterMobileNumber();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [Given(@"I enter confirm password")]
        public void GivenIEnterConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();  
        }

         [When(@"I click on terms of use")]
        public void WhenIClickOnTermsOfUse()
        {
           registrationPage.ClickTermsOfUse();
        }

        [When(@"I click on privacy policy")]
        public void WhenIClickOnPrivacyPolicy()
        {
            registrationPage.ClickPrivacyPolicy();  
        }

        [When(@"I click on register")]
        public void WhenIClickOnRegister()
        {
            registrationPage.ClickRegister();  
        }
        
        [Then(@"I am sucessfully registered")]
        public void ThenIAmSucessfullyRegistered()
        {
            
        }
    }
}
