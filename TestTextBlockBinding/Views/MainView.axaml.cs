using System;

using Avalonia.Controls;
using Avalonia.Interactivity;

using TestTextBlockBinding.ViewModels;


namespace TestTextBlockBinding.Views;


public partial class MainView : UserControl
{

  private MainViewModel vm = new ();

  public MainView ()
  {
    InitializeComponent ();

    DataContext = vm;
    ByCode.Text = vm.Counter.ToString ();
  }



  private void Button_OnClick (Object? sender, RoutedEventArgs e)
  {
    vm.Counter += 1;

    ByCode.Text = vm.Counter.ToString ();
  }

}