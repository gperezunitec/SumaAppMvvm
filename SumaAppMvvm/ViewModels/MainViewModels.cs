using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels;

public partial class MainViewModels: ObservableObject
{

    [ObservableProperty] 
    private double a;
    
    [ObservableProperty]
    private double b;
    
    [ObservableProperty]
    private double c;


    [RelayCommand]
    private void Sumar()
    {
        C = A + B;
    }


    [RelayCommand]
    private void Limpiar()
    {
        A = 0;
        B = 0;
        C = 0;
    }
    
    
    private void Alerta(string Titulo, string Mensaje)
    {
        MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
    }

}