namespace Calculadora;

public class Menu
{
    public void MostrarMenu()
    {
        Console.WriteLine("0. Entrar dades de Persona des de terminal");
        Console.WriteLine("1. Mostrar dades de Persona");
        Console.WriteLine("2. Convertir Persona a JSON");
        Console.WriteLine("3. Convertir Persona a XML");
        Console.WriteLine("4. Convertir JSON a Persona");
        Console.WriteLine("5. Convertir XML a Persona");
        Console.WriteLine("6. Persistir cadena json a disc");
        Console.WriteLine("7. Llegir cadena json des de disc");
        Console.WriteLine("8. Persistir cadena xml a disc");
        Console.WriteLine("9. Llegir cadena xml des de disc");
        Console.WriteLine("10. Mostrar cadena");      
        Console.WriteLine("11. Sortir");
    }
    public int LlegirOpcio()
    {
        Console.Write("Selecciona una opció: ");
        int opcio;
        while (!int.TryParse(Console.ReadLine(), out opcio) || opcio < 0 || opcio > 11)
        {
            Console.Write("Opció no vàlida. Selecciona una opció: ");
        }
        return opcio;
    }
}
