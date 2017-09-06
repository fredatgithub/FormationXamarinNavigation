using Xamarin.Forms;

namespace Navigation
{
    internal class StartPage:TabbedPage
    {
        public StartPage()
        {
            Children.Add(new XfNavigation());
            Children.Add(new NavigationCode());
        }
    }
}