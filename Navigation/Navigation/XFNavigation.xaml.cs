using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class XfNavigation : ContentPage
  {
    public XfNavigation()
    {
      InitializeComponent();
    }

    private void BtnToPage2_OnClicked(object sender, EventArgs e)
    {
      //DisplayAlert("titre", "message", "cancel");
      //InitializeComponent();
      //NavigationPage.SetHasNavigationBar(this, false);
      //lblTime.Text = DateTime.Now.ToLocalTime().ToString();
      //var pageRef = new Page1();
      //Navigation.PushAsync(new Page2());
      //MainPage = new NavigationPage(new EmployeeListPage());
      //MainPage =  new NavigationPage(new Page2());
      Navigation.PushAsync(new Page2());
    }

    private void BtnToPage3_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new Page3());
    }
  }
}