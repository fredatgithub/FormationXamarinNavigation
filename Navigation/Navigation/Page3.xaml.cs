using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Page3 : ContentPage
  {
    public Page3()
    {
      InitializeComponent();

      NavigationPage.SetHasNavigationBar(this, true);
      LblMemory.Text = DateTime.Now.ToLocalTime().ToString();
      //Timer
      List<Byte[]> liste = new List<byte[]>();
      //no callback
      //liste.Add(new byte[1024 * 100]);
      //ShowMemoryAllocation();
      Device.StartTimer(new TimeSpan(0, 0, 2), () =>
      {
        liste.Add(new byte[1024 * 10]);
        ShowMemoryAllocation();
        return true;
      });

      ShowMemoryAllocation();
    }
    private void ShowMemoryAllocation()
    {
      //Nombre correspondant à la meilleure approximation possible du nombre d'octets
      //actuellement alloués dans la mémoire managée.
      LblMemory.Text = string.Format($"Mémoire allouée {GC.GetTotalMemory(true).ToString()}");
    }
  }
}