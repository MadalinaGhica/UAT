using System;
using System.IO;
using NUnit.Framework;
using Xamarin.UITest;

namespace Test.UiTest.Pages
{
    public abstract class BasePageObject
    {
        protected IApp app => AppInitializer.App;
        protected bool OnAndroid => AppInitializer.Platform == Platform.Android;
        protected bool OniOS => AppInitializer.Platform == Platform.iOS;

        protected abstract PlatformQuery Trait { get; }

        protected BasePageObject()
        {
            //AssertOnPage(TimeSpan.FromSeconds(5));
           // app.Screenshot("On " + this.GetType().Name);
        }

        public void AssertOnPage(TimeSpan? timeout = default(TimeSpan?))
        {
            var message = "Unable to verify on page: " + this.GetType().Name;

            if (timeout == null)
                Assert.IsNotEmpty(app.Query(Trait.Current), message);
            else
                Assert.DoesNotThrow(() => app.WaitForElement(Trait.Current, timeout: timeout), message);
        }

        public void WaitForPageToLeave(TimeSpan? timeout = default(TimeSpan?))
        {
            timeout = timeout ?? TimeSpan.FromSeconds(5);
            var message = "Unable to verify *not* on page: " + this.GetType().Name;

            Assert.DoesNotThrow(() => app.WaitForNoElement(Trait.Current, timeout: timeout), message);
        }

        public BasePageObject TapOnHardwareBackbutton()
        {
            app.Back();
            return this;
        }

        public void SaveScreenshot(string title)
        {
            var fileInfo = app.Screenshot(title);
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var screenshotPath = Path.Combine(basePath, $"../../Reports/{title}");
            if (File.Exists(screenshotPath))
            {
                File.Delete(screenshotPath);
            }
            fileInfo.MoveTo(screenshotPath);
        }

        public abstract void WaitForAllElements();

    }
}
