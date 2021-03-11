using System;
namespace Test.UiTest.Pages
{
    public class NewPageObject
    {
        #region Properties

        public AddPageObject AddPage { get; set; }
        public MenuPageObject MenuPage { get; set; }
        public BrowsePageObject BrowsePage { get; set; }
        public AboutPageObject AboutPage { get; set; }
        public ItemDetailPage ItemPage { get; set; }

        

        #endregion

        #region Constructor

        public NewPageObject()
        {
            AddPage = new AddPageObject();
            MenuPage = new MenuPageObject();
            BrowsePage = new BrowsePageObject();
            AboutPage = new AboutPageObject();
            ItemPage = new ItemDetailPage();
        }

        #endregion

    }
}
