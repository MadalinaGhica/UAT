using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Test.UiTest.Pages
{
    public class AboutPageObject : BasePageObject
    {
        private const string LearnMoreId = "NoResourceEntry-33";
        private const string OkId = "OK";

        private readonly Query LearnMoreButton;
        private readonly Query OkButton;

        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("AboutPage"),
            iOS = x => x.Marked("AboutPage")
        };

        public AboutPageObject()
        {
            LearnMoreButton = x => x.Marked(LearnMoreId);
            OkButton = x => x.Marked(OkId);
        }

        public AboutPageObject TapLearnMoreButton()
        {
            app.Tap(LearnMoreButton);
            SaveScreenshot(nameof(TapLearnMoreButton));
            return this;
        }

        public AboutPageObject TapMenuButton()
        {
            app.Tap(OkButton);
            SaveScreenshot(nameof(TapMenuButton));
            return this;
        }

        public override void WaitForAllElements()
        {
            WaitForAllElementsAboutPage();

            SaveScreenshot(nameof(WaitForAllElementsAboutPage));

        }

        public void WaitForAllElementsAboutPage()
        {
            app.WaitForElement(LearnMoreButton);
            app.WaitForElement(OkButton);
          
        }

    }
}
