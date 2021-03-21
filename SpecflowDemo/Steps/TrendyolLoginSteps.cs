using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowDemo.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDemo.Steps
{
    [Binding]
    public sealed class TrendyolLoginSteps
    {
        private LoginPage loginPage = null;
        // Anti-Context Injection code
        //Step definations
        [Given(@"I launch the trendyol")]
        public void GivenILaunchTheTrendyol()
        {
            IWebDriver webDriver = new ChromeDriver();
           // webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.trendyol.com/butik/liste/erkek");
            loginPage = new LoginPage(webDriver);
        }
        //[Given(@"I close the modal")]
        //public void GivenICloseTheModal()
        //{
        
        //}


        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
           loginPage.GoToLoginPage();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterLogin((string)data.Email,(string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }


        [Then(@"I should see Error Message")]
        public void ThenIShouldSeeErrorMessage()
        {
            Assert.IsTrue(loginPage.IsShowMessage());
        }

    }
}
