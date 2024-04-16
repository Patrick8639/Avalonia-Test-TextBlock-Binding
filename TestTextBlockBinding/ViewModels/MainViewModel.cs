using System;

using ReactiveUI;


namespace TestTextBlockBinding.ViewModels;


public class MainViewModel : ViewModelBase
{

  private Int32 _Counter;
  public Int32 Counter
  {
    get => _Counter;
    set => this.RaiseAndSetIfChanged (ref _Counter, value);
  }
}