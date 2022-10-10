internal class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);

        Console.WriteLine("Ingrese el modelo del vehiculo");
        objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese la marca del vehiculo ");
        objAutomovil.DefinirMarca(Console.ReadLine());

        Console.WriteLine("Ingrese el precio de vehiculo ");
        objAutomovil.DefinirPrecio(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el cambio ");
        objAutomovil.DefinirCambio(double.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese el descuento ");
        objAutomovil.DefinirDescuento(double.Parse(Console.ReadLine()));

        Console.WriteLine("Datos Ingresados: " + objAutomovil.MostrarInfomracion());

        Console.ReadKey();
    }
}
class Automovil
{
    private int Modelo;
    private double Precio;
    private string Marca;
    private bool Disponible;
    private double cambio;
    private double descuento;

    public Automovil(int Modelo, double Precio, string Marca, bool Disponible, double Cambio, double Descuento)
    {
        Modelo = Modelo;
        Precio = Precio;
        Marca = Marca;
        Disponible = Disponible;
        cambio = Cambio;
        descuento = Descuento;
    }

    public void DefinirModelo(int unModelo)
    {
        Modelo = unModelo;
    }

    public void DefinirPrecio(int unPrecio)
    {
        Precio = unPrecio;
    }

    public void DefinirMarca(string unaMarca)
    {
        Marca = unaMarca;
    }

    public void DefinirCambio(double unCambio)
    {
        cambio = unCambio;
    }

    public void DefinirDescuento(double unDescuento)
    {
        descuento = unDescuento;
    }

    public void CambiarDisponible()
    {
        if (Disponible == true)
        {
            Disponible = false;
        }
        else
        {
            Disponible = true;
        }
    }
    public string MostrarDisponible()
    {
        {
            if (Disponible == false)
            {
                return "disponible";
            }
            else
            {
                return "no disponible";
            }
        }
    }
    public string MostrarInfomracion()
    {
   return "Modelo: "   + Modelo +   " Marca: "   + Marca +   " Precio: "   + Precio +   " El cambio es: " +   cambio   +  " Descuento: " +  descuento;
    }
}