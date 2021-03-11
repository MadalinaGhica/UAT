using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Test.UiTest
{
    public class PlatformQuery
    {
        public Func<AppQuery, AppQuery> Android
        {
            set
            {
                if (AppInitializer.Platform == Platform.Android)
                    current = value;
            }
        }

        public Func<AppQuery, AppQuery> iOS
        {
            set
            {
                if (AppInitializer.Platform == Platform.iOS)
                    current = value;
            }
        }

        Func<AppQuery, AppQuery> current;
        public Func<AppQuery, AppQuery> Current
        {
            get
            {
                if (current == null)
                    throw new NullReferenceException("Trait not set for current platform");

                return current;
            }
        }
    }
}
