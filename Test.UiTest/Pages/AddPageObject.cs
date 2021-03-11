using System;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Test.UiTest.Pages
{
    public class AddPageObject : BasePageObject
    {
        public string NumeItem { get; set; }


        private const string ItemNameId = "NoResourceEntry-34";
        private const string ItemDescriptionId = "NoResourceEntry-36";
        private const string CancelId = "Cancel";
        private const string SaveId = "Save";

        private readonly Query ItemNameField;
        private readonly Query ItemDescriptionField;
        private readonly Query CancelButton;
        private readonly Query SaveButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("NewItemPage"),
            iOS = x => x.Marked("NewItemPage")
        };

        public AddPageObject()
        {
            ItemNameField = x => x.Marked(ItemNameId);
            ItemDescriptionField = x => x.Marked(ItemDescriptionId);
            CancelButton = x => x.Marked(CancelId);
            SaveButton = x => x.Marked(SaveId);

        }

        public AddPageObject TapItemName()
        {
            app.Tap(ItemNameId);
            SaveScreenshot(nameof(TapItemName));
            return this;
        }

        public void EnterItemName(string itemName)
        {
            app.ClearText(ItemNameId);
            app.EnterText(itemName);
           // app.EnterText(c => c.Class(ItemNameId), Console.ReadLine());
            SaveScreenshot(nameof(EnterItemName));
        }

        public AddPageObject TapItemDescription()
        {
            app.Tap(ItemDescriptionId);
            SaveScreenshot(nameof(TapItemDescription));
            return this;

        }

        public void EnterItemDescription(string itemDescription)
        {
            app.ClearText(ItemDescriptionId);
            app.EnterText(itemDescription);
            SaveScreenshot(nameof(EnterItemDescription));

        }

        public AddPageObject TapSave()
        {
            app.Tap(SaveId);
            SaveScreenshot(nameof(TapSave));
            return this;

        }

        public AddPageObject TapCancel()
        {
            app.Tap(CancelId);
            SaveScreenshot(nameof(TapCancel));
            return this;

        }

        public override void WaitForAllElements()
        {
            WaitForAllElementsAddPage();

            SaveScreenshot(nameof(WaitForAllElementsAddPage));

        }

        public void WaitForAllElementsAddPage()
        {
            app.WaitForElement(ItemNameField);
            app.WaitForElement(ItemDescriptionField);
            app.WaitForElement(CancelButton);
            app.WaitForElement(SaveButton);

        }

    }
}
