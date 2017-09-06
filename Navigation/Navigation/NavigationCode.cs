using Xamarin.Forms;

namespace Navigation
{
    public class NavigationCode : ContentPage
    {
        public NavigationCode()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin Forms!" }
                }
            };
        }
    }
}