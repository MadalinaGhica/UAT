using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Test.UiTest
{
    public class AppInitializer
    {
        public static IApp App { get; set; }
        public static Platform Platform { get; set; }

        public static void StartApp()
        {
            switch (Platform)
            {
                case Platform.Android:
                    {
                     App = ConfigureApp
                    .Android.Debug().EnableLocalScreenshots()
                    .StartApp();
                     break;
                    }


                case Platform.iOS:
                    {
                     App = ConfigureApp
                     .iOS.Debug().EnableLocalScreenshots()
                     .StartApp();
                     break;
                    }
            }
            
        }
    }
}
