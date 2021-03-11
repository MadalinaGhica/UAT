using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Test.UiTest.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Test.UiTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BaseTestFixture
    {
        public NewPageObject Page { get; set; }

        protected IApp App => AppInitializer.App;
        protected bool OnAndroid => AppInitializer.Platform == Platform.Android;
        protected bool OniOS => AppInitializer.Platform == Platform.iOS;

        public BaseTestFixture(Platform platform)
        {
            AppInitializer.Platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            AppInitializer.StartApp();
            Page = new NewPageObject();
            
        }

    }
}
