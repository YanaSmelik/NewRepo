using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Coursera_auto_test.PageObjects
{
    public class LoginPage
    {

        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.CssSelector, Using = "#AuthEmail")]
        public IWebElement EmailAddressBox { get; set; }

        [FindsBy (How = How.Id, Using = "connect-iframe")]
        public IWebElement LoginFormFrame { get; set; }

        [FindsBy (How = How.Id, Using = "AuthPassword")]
        public IWebElement PasswordBox { get; set; }

        [FindsBy (How = How.CssSelector, Using = "body > app-component > div > app-login-component > main > app-login-shared-component > section > form > button")]
        public IWebElement LogInButton { get; set; }



    }
}
