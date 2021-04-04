using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowDemo.Pages
{
    public class LoginPage
    {
        
        public  IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.ClassName("account-user"));
        public IWebElement txtEmail => WebDriver.FindElement(By.Id("login-email"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Id("login-password-input"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector("#login-register > div.lr-container > div.q-layout.login > form > button"));
        public IWebElement txtMessage => WebDriver.FindElement(By.XPath("//*[@id=\"error-box-wrapper\"]"));
        public IWebElement btnCloseModal => WebDriver.FindElement(By.ClassName("message"));

        public void CloseModal() => btnCloseModal.Click();
        public void GoToLoginPage() => lnkLogin.Click();

        public void EnterLogin(string email, string password)
        {
          

            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);

        }

        public void ClickLoginButton() => btnLogin.Click();

        public bool IsShowMessage()
        {

            Thread.Sleep(500);
            
            return txtMessage.Displayed;
        }

        public void CloseDriver() => WebDriver.Close();
    }
}
