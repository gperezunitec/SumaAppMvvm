using CommunityToolkit.Mvvm.ComponentModel;

namespace SumaAppMvvm.ViewModels;

public partial class MainViewModels: ObservableObject
{

    [ObservableProperty] 
    private double a;
    
    [ObservableProperty]
    private double b;
    
    [ObservableProperty]
    private double c;
    
    
    
    private void Alerta(string Titulo, string Mensaje)
    {
        MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
    }

}