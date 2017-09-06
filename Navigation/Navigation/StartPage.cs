using Xamarin.Forms;

namespace Navigation
{
    internal class StartPage:TabbedPage
    {
        private StartPage()
        {
            Children.Add(new XFNavigation());
            Children.Add(new NavigationCode());

        }
    }
}
