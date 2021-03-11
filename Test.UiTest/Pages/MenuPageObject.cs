using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Test.UiTest.Pages
{
    public class MenuPageObject : BasePageObject
    {
        private const string BrowseId = "Browse";
        private const string AboutId = "About";

        private readonly Query BrowseButton;
        private readonly Query AboutButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("MenuPage"),
            iOS = x => x.Marked("MenuPage")
        };

        public MenuPageObject()
        {
            BrowseButton = x => x.Marked(BrowseId);
            AboutButton = x => x.Marked(AboutId);

        }

        public MenuPageObject TapBrowse()
        {
            app.Tap(BrowseButton);
            SaveScreenshot(nameof(TapBrowse));
            return this;
        }

        public MenuPageObject TapAbout()
        {
            app.Tap(AboutButton);
            SaveScreenshot(nameof(TapAbout));
            return this;
        }

        public override void WaitForAllElements()
        {
            WaitForAllElementsMenuPage();

            SaveScreenshot(nameof(WaitForAllElementsMenuPage));

        }

        public void WaitForAllElementsMenuPage()
        {
            app.WaitForElement(BrowseButton);
            app.WaitForElement(AboutButton);
        }
    }
}
