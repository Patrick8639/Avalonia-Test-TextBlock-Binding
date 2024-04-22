using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using TestTextBlockBinding.ViewModels;
using TestTextBlockBinding.Views;


namespace TestTextBlockBinding;


public partial class App : Application
{

  public override void Initialize ()
  {
    AvaloniaXamlLoader.Load (this);
  }



  public override void OnFrameworkInitializationCompleted ()
  {
    if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
    {
      desktop.MainWindow = new MainWindow
      {
        DataContext = new MainViewModel ("I'm created from App.axaml.cs (DesktopLifeTime). I override the DataContext of MainWindow")
      };
    }
    else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
    {
      singleViewPlatform.MainView = new MainView
      {
        DataContext = new MainViewModel ("I'm created from App.axaml.cs (SingleLifetime).  I override the DataContext of MainView")
      };
    }

    base.OnFrameworkInitializationCompleted ();
  }

}