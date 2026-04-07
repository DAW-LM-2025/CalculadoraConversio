namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Estat estat = new();
        Manager manager = new(estat);

        bool sortir = false;
        while (!sortir)
        {
            menu.MostrarMenu();
            var opcio = menu.LlegirOpcio();
            sortir = opcio == 11;
            try{
                manager.ExecutaOpcio(opcio);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
    }
}
