using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Input;

namespace ExamenII__ProgramacionII
{ 
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private decimal producto1;

    [ObservableProperty]
    private decimal producto2;

    [ObservableProperty]
    private decimal producto3;

    [ObservableProperty]
    private decimal subtotal;

    [ObservableProperty]
    private decimal descuento;

    [ObservableProperty]
    private decimal total;

    public MainViewModel()
    {
        LimpiarCommand = new RelayCommand(Limpiar);
        CalcularCommand = new RelayCommand(Calcular);
    }

    public ICommand LimpiarCommand { get; set; }
    public ICommand CalcularCommand { get; set; }

    private void Calcular()
    {
        Subtotal = Producto1 + Producto2 + Producto3;
        Descuento = 0;

        if (Subtotal >= 1000 && Subtotal < 5000)
        {
            Descuento = 0.1m;
        }
        else if (Subtotal >= 5000 && Subtotal < 10000)
        {
            Descuento = 0.2m;
        }
        else if (Subtotal >= 10000)
        {
            Descuento = 0.3m;
        }

        Total = Subtotal - (Subtotal * Descuento);
    }

    private void Limpiar()
    {
        Producto1 = Producto2 = Producto3 = 0;
        Subtotal = Descuento = Total = 0;
    }

    partial void OnProducto1Changed(decimal value)
    {
        if (value < 0) Producto1 = 0;
    }

    partial void OnProducto2Changed(decimal value)
    {
        if (value < 0) Producto2 = 0;
    }

    partial void OnProducto3Changed(decimal value)
    {
        if (value < 0) Producto3 = 0;
    }

}
}
