using System;
using System.Collections.Generic;
using System.Linq;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Test.UiTest.Pages
{
    public class BrowsePageObject : BasePageObject
    {
        public string NumeItem { get; set; }

        private const string AddId = "Add";
        private const string BrowseId = "OK";
        private const string ItemId = "list_Items";

        private readonly Query AddButton;
        private readonly Query BrowseButton;
        private readonly Query ItemButton;

        public int NrListaItem => app.Query("ItemList").First().Label.Count();

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("BrowseItemsPage"),
            iOS = x => x.Marked("BrowseItemsPage")
        };

        public BrowsePageObject()
        {

            AddButton = x => x.Marked(AddId);
            BrowseButton = x => x.Marked(BrowseId);
            ItemButton = x => x.Marked(ItemId);
       
        }

        public BrowsePageObject TapItem(int index)
        {
            app.Tap(x => x.Marked(ItemId).Index(index));
            SaveScreenshot(nameof(TapItem));
            return this;
        }

        public BrowsePageObject TapAddItem()
        {
            app.Tap(AddButton);
            SaveScreenshot(nameof(TapAddItem));
            return this;
        }

        public BrowsePageObject TapMenu()
        {
            //var MenuButton = app.Query(x => x.Marked("BrowseItemsPage").Descendant(43));
            app.Tap(BrowseButton);
            SaveScreenshot(nameof(TapMenu));
            return this;
        }

        public string SearchItemByName(string nameText)
        {
            var result = app.Query(ItemButton).Last(x => x.Text == nameText).Text;
            SaveScreenshot(nameof(SearchItemByName));

            return result;
        }

        public override void WaitForAllElements()
        {
            WaitForAllElementsBrowsePage();

            SaveScreenshot(nameof(WaitForAllElementsBrowsePage));

        }

        public void WaitForAllElementsBrowsePage()
        {
            app.WaitForElement(AddButton);
            app.WaitForElement(BrowseButton);
            app.WaitForElement(ItemButton);

        }

    }
}
