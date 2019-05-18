using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Coursera_auto_test.PageObjects
{
    public class UserHomePage
    {
        public UserHomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy (How = How.Id, Using = "overlay-iframe")]
        public IWebElement UserCardFrame { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container")]
        public IWebElement UserCardAvatarHolder { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_container_content_user > div > div > img")]
        public IWebElement UserCardAvatar { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.mobileNav.visible > div.userPanelBtn.active > div > i")]
        public IWebElement UserSettingsTab { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_user-panel.visible > div > div:nth-child(1) > div > div > div.choose-from-gallery-container > div.platform-input-selector.in-back.load-element > div.platform-input-selected-btn")]
        public IWebElement SelectAvatarDropDown { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_user-panel.visible > div > div:nth-child(1) > div > div.contentBlock.playerCard > div > div > div.img-holder > div > img")]
        public IWebElement UserCurrentAvatar { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_user-panel.visible > div > div:nth-child(1) > div > div > div.choose-from-gallery-container > div.platform-input-selector.in-back.load-element.is-opened > div.platform-input-component-view > div:nth-child(15)")]
        public IWebElement SelectAvatarR6 { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_user-panel.visible > div.avatars-confirmation-container.positioned > div > div.accept-btn.cta > span")]
        public IWebElement ConfirmPictureSelection { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.mobileNav.visible > div.friendsPanelBtn > div > i")]
        public IWebElement FriendsDropDown { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > ul > div.menu_friends-panel-container > div > div > div:nth-child(1) > div > div:nth-child(2) > div.add-friend-button > span")]
        public IWebElement AddFriendButton { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > ul > div.menu_friends-panel-container > div > div > div:nth-child(1) > div > div.add-friend-tab-view > div:nth-child(2) > article > fieldset > input[type=text]")]
        public IWebElement FindFriendTextBox { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > ul > div.menu_friends-panel-container > div > div > div:nth-child(1) > div > div.add-friend-tab-view > div:nth-child(2) > article > fieldset > button")]
        public IWebElement FindFriendButton { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > ul > div.menu_friends-panel-container > div > div > div:nth-child(1) > div > div.add-friend-tab-view > div:nth-child(2) > article > div > div:nth-child(2) > div > div > div.user-actions.add-friend-type > div > a > span")]
        public IWebElement InviteFriendButton { get; set; }

        [FindsBy (How = How.CssSelector, Using = "#menu > div.menu_container > div.menu_user-panel.visible > div > div:nth-child(1) > div > section > ul > li.logout > div")]
        public IWebElement LotOutButton { get; set; }
    }
}
