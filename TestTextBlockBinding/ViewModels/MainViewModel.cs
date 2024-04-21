using System;
using System.Diagnostics;
using ReactiveUI;


namespace TestTextBlockBinding.ViewModels;


public class MainViewModel : ViewModelBase
{

  private Int32 _Counter;

  public MainViewModel(string createMessage)
  {
    Debug.WriteLine(createMessage);
  }

  public MainViewModel() : this("I was created without any parameter")
  {
    
  }

  public Int32 Counter
  {
    get => _Counter;
    set => this.RaiseAndSetIfChanged (ref _Counter, value);
  }
}