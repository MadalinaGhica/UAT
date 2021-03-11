using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace Test.UiTest.Tests
{
    public class AboutTest :BaseTestFixture
    {
        public AboutTest(Platform platform) : base(platform)
        {
        }

        [Test]
        public void VerifyAccessAboutPage()
        {
            // Arrange 


            // Act
            Page.BrowsePage.TapMenu();
            Page.MenuPage.TapAbout();


            // Assert
            Page.BrowsePage.WaitForPageToLeave();
            Page.AboutPage.AssertOnPage();

        }

        [Test]
        public void ClickLearnMoreAboutPage()
        {
            // Arrange 


            // Act
            Page.BrowsePage.TapMenu();
            Page.MenuPage.TapAbout();
            Page.AboutPage.TapLearnMoreButton();


            // Assert
            Page.AboutPage.WaitForPageToLeave();

        }

        [Test]
        public void VerifyAccessBrowsePage()
        {
            // Arrange 


            // Act
            Page.BrowsePage.TapMenu();
            Page.MenuPage.TapAbout();
            Page.AboutPage.TapMenuButton();
            Page.MenuPage.TapBrowse();


            // Assert
            Page.BrowsePage.AssertOnPage();
            Page.AboutPage.WaitForPageToLeave();

        }

    }
}
