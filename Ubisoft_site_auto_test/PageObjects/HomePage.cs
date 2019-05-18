

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Coursera_auto_test
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy (How = How.CssSelector, Using = "#overlay-iframe")]
        public IWebElement LoginFrame { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#root > div > div > a")]
        public IWebElement LogInButton { get; set;  }
        
        [FindsBy (How = How.CssSelector, Using = "#___gatsby > div > div > div > div.hideButton.headerstyles__HeaderContainer-sc-1va93d8-2.kHwPCY > div > div.headerstyles__LeftSidebar-sc-1va93d8-4.kSKgte > ul > li:nth-child(2) > a")]
        public IWebElement GamesTab { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.control.styles__Control-kt7x31-0.hIWHVK > div.select.arrow")]
        public IWebElement LanguageDropDown { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.menu.styles__OptionsList-kt7x31-1.flYZUY > div:nth-child(1)")]
        public IWebElement LanguageEng { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.menu.styles__OptionsList-kt7x31-1.flYZUY > div:nth-child(2)")]
        public IWebElement LanguageFR { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.menu.styles__OptionsList-kt7x31-1.flYZUY > div:nth-child(3)")]
        public IWebElement LanguageIt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.menu.styles__OptionsList-kt7x31-1.flYZUY > div:nth-child(4)")]
        public IWebElement LanguageDe { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#___gatsby > div > div > div > div.styles__Container-sc-1ejj94l-5.nFMFT > div > div.styles__RightPane-sc-1ejj94l-4.hfHosh > div > div > div.select.menu.styles__OptionsList-kt7x31-1.flYZUY > div:nth-child(5)")]
        public IWebElement LanguageSp { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#___gatsby > div > div > div > div.es-ES.contentstyles__Container-sc-6lc0uh-6.eTkgWp > div.section.be_awesome.styles__Container-sc-1j2y4kk-1.cWtfjX > div > div > div > a")]
        public IWebElement DownloadButtonFooter { get; set; }
    }
        
      
    
}
