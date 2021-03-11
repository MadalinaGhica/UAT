using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace Test.UiTest.Tests
{
    public class BrowseTest : BaseTestFixture
    {
        public BrowseTest(Platform platform) : base(platform)
        {
        }

        [Test]
        public void VerifyItemPageOpens()
        {
            // Arrange 
            var itemText = "First item";
            var itemDescription = "This is an item description.";

            // Act
            Page.BrowsePage.TapItem(0);

            // Assert
            Page.ItemPage.AssertOnPage();
            Assert.AreEqual(itemText, Page.ItemPage.GetItemText());
            Assert.AreEqual(itemDescription, Page.ItemPage.GetItemDescription());

        }




    }
}
