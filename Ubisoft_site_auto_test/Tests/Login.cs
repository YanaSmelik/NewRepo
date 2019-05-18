

using Coursera_auto_test.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;

namespace Coursera_auto_test.Tests
{

    public class Login

    {
        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();
        UserHomePage userHomePage = new UserHomePage();

        public void Wait(IWebElement element, int time)
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }


        public Login()
        {


        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        


        [OneTimeSetUp]

        public void Initialize()
        {
            Driver.driver.Navigate().GoToUrl("https://uplay.ubisoft.com");
            Driver.driver.Manage().Window.Maximize();
            Wait(homePage.LoginFrame, 10);
        }
        

        [Test]
        public void _1_French()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageFR.Click();
            Thread.Sleep(1000);
            string gametab = homePage.GamesTab.Text;
            Assert.True(Equals(gametab, "PLUS DE JEUX"));
        }

        [Test]
        public void _2_English()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageEng.Click();
            Thread.Sleep(1000);
            string gametab = homePage.GamesTab.Text;
            Assert.True(Equals(gametab, "MORE GAMES"));
        }

        [Test]
        public void _3_Italian()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageIt.Click();
            Thread.Sleep(1000);
            string gametab = homePage.GamesTab.Text;
            Assert.True(Equals(gametab, "ALTRI GIOCHI"));
        }

        [Test]
        public void _4_German()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageDe.Click();
            Thread.Sleep(1000);
            string gametab = homePage.GamesTab.Text;
            Assert.True(Equals(gametab, "MEHR SPIELE"));
        }

        [Test]
        public void _5_Spanish()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageSp.Click();
            Thread.Sleep(1000);
            string downloadButton = homePage.DownloadButtonFooter.Text;
            Assert.True(Equals(downloadButton, "Descargar"));
        }

        [Test]
        public void _6_Login_test_wrong_username()
        {
            homePage.LanguageDropDown.Click();
            homePage.LanguageEng.Click();
            Thread.Sleep(1000);
            
            Driver.driver.SwitchTo().Frame(homePage.LoginFrame);
            homePage.LogInButton.Click();
            Driver.driver.SwitchTo().DefaultContent();
            Driver.driver.SwitchTo().Frame(loginPage.LoginFormFrame);
            Wait(loginPage.EmailAddressBox, 10);
            loginPage.EmailAddressBox.SendKeys("yanate@gmail.com");
            loginPage.PasswordBox.SendKeys("123-QAZxsw");
            loginPage.LogInButton.Click();
            Wait(userHomePage.UserCardFrame, 1);
            
        }

        [Test]
        public void _7_Login_test_wrong_password()
        {

            
            loginPage.EmailAddressBox.Clear();
            loginPage.PasswordBox.Clear();
            loginPage.EmailAddressBox.SendKeys("yanatest24@gmail.com");
            loginPage.PasswordBox.SendKeys("123v-QAZxsw");
            loginPage.LogInButton.Click();
            Wait(userHomePage.UserCardFrame, 1);
           
        }

        [Test]
        public void _8_Login_test()
        {
            loginPage.EmailAddressBox.Clear();
            loginPage.PasswordBox.Clear();
            loginPage.EmailAddressBox.SendKeys("yanatest24@gmail.com");
            loginPage.PasswordBox.SendKeys("123-QAZxsw");
            loginPage.LogInButton.Click();
            Wait(userHomePage.UserCardFrame, 10);
            Driver.driver.SwitchTo().Frame(userHomePage.UserCardFrame);
            Wait(userHomePage.UserCardAvatarHolder, 10);
        }

        [Test]
        public void _9_Change_avatar()
        {
            
            userHomePage.UserCardAvatarHolder.Click();
            
            Wait(userHomePage.UserSettingsTab, 10);
            
            
            userHomePage.UserSettingsTab.Click();
            Wait(userHomePage.UserCurrentAvatar, 10);

            userHomePage.UserCurrentAvatar.Click();
            Wait(userHomePage.SelectAvatarDropDown, 10);

           
            userHomePage.SelectAvatarDropDown.Click();
            userHomePage.SelectAvatarR6.Click();

            int rand = RandomNumber(1, 40);

            IWebElement newR6picture = Driver.driver.FindElement(By.CssSelector("#menu > div.menu_container > div.menu_user-panel.visible > div > div:nth-child(1) > div > div > div.choose-from-gallery-container > div.avatars-container > div:nth-child(" + rand + ") > img"));
            Wait(newR6picture, 10); 
            newR6picture.Click();
            Wait(userHomePage.ConfirmPictureSelection, 10);

           
            userHomePage.ConfirmPictureSelection.Click();
            Wait(userHomePage.UserCurrentAvatar, 10);
           
        }
        

        [Test]
        public void _Logout()
        {
            userHomePage.UserSettingsTab.Click();
            Thread.Sleep(1000);
            userHomePage.LotOutButton.Click();
            Thread.Sleep(2000);

        }



        [OneTimeTearDown]
        public void CleanUP()
        {
            Driver.driver.Quit();
        }

    }

}
