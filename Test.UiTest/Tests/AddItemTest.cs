using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace Test.UiTest.Tests
{
    public class AddItemTest: BaseTestFixture
    {
        public AddItemTest(Platform platform) : base (platform)
        {
        }

        [Test]
        public void Repl()
        {
            App.Repl();
        }

        [Test]
        public void VerifySaveAddItem()
        {
            // Arrange 
            var itemName = "Mada";
            var itemdesc = "Mada's item";

            // Act
            Page.BrowsePage.TapAddItem();
            Page.AddPage.TapItemName();
            Page.AddPage.EnterItemName(itemName);
            Page.AddPage.TapItemDescription();
            Page.AddPage.EnterItemDescription(itemdesc);
            Page.AddPage.TapSave();
           
            var actual_Name = Page.BrowsePage.SearchItemByName(itemName);

            // Assert
            Assert.AreEqual(itemName, actual_Name);
            Page.BrowsePage.AssertOnPage();

        }

        [Test]
        public void VerifyCancelAddItem()
        {
          

            // Act
            Page.BrowsePage.TapAddItem();
            Page.AddPage.TapCancel();
            

            // Assert
            Page.AddPage.WaitForPageToLeave();

        }


    }
}
