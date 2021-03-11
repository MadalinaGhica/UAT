using System;
using System.Collections;
using System.Linq;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Test.UiTest.Pages
{
    public class ItemDetailPage : BasePageObject
    {
        private const string ItemTextId = "NoResourceEntry-28";
        private const string ItemTextDescriptionId = "NoResourceEntry-30";

        private readonly Query ItemText;
        private readonly Query ItemTextDescription;


        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("ItemDetailPage"),
            iOS = x => x.Marked("ItemDetailPage")
        };

        public ItemDetailPage()
        {
            ItemText = x => x.Marked(ItemTextId);
            ItemTextDescription = x => x.Marked(ItemTextDescriptionId);
        }

        public ItemDetailPage TapBackButton()
        {
            var backButton = app.Query(x=> x.Marked("ItemDetailPage").Descendant(13)).ToString();
            SaveScreenshot(nameof(TapBackButton));
            return this;
        }

        public string GetItemText()
        {
            var text = app.Query(ItemText).Last().Text;
            SaveScreenshot(nameof(GetItemText));
            return text;
        }

        public string GetItemDescription()
        {
            var text = app.Query(ItemTextDescription).Last().Text;
            SaveScreenshot(nameof(GetItemText));
            return text;
        }


        public override void WaitForAllElements()
        {
            WaitForAllElementsItemDetailPage();

            SaveScreenshot(nameof(WaitForAllElementsItemDetailPage));

        }

        public void WaitForAllElementsItemDetailPage()
        {
            var backButton = app.Query(x => x.Marked("ItemDetailPage").Descendant(13)).ToString();
            app.WaitForElement(backButton);

        }

    }
}
