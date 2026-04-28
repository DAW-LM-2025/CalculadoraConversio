using Conversors;

namespace Calculadora;

public class Manager
{
    protected Estat Estat { get; set; }
    public Manager(Estat estat)
    {
        Estat = estat;
    }
    
    public void ExecutaOpcio(int opcio)
    {
        switch (opcio)
        {
            case 0:
                Console.WriteLine("Has seleccionat l'opció 0: Entrar dades de Persona");
                // Validacions
                // No hi ha validacions específiques per a aquesta opció, ja que es tracta d'entrar dades de persona. No obstant això, es podria considerar afegir validacions per assegurar-se que les dades introduïdes siguin correctes (per exemple, que l'edat sigui un número positiu).
                // Actualitzar Estat: EstatPersona = PossiblesEstatsPersona.Persona;
                // Execució
                // Demanar per pantalla les dades de la persona i crear l'objecte Persona amb aquestes dades.

                Estat.Persona = new();
                Estat.EstatPersona = Estat.PossiblesEstatsPersona.Persona;

                Console.WriteLine("Nom de la persona:");
                Estat.Persona.Nombre = Console.ReadLine()!;

                Console.WriteLine("Edat de la persona:");
                Estat.Persona.Edad = int.Parse( Console.ReadLine()! );

                break;
            case 1:
                Console.WriteLine("Has seleccionat l'opció 1: Mostrar dades de Persona");
                // Validacions
                // Comprovar que hi hagi una persona informada abans de mostrar les dades (EstatPersona == PossiblesEstatsPersona.Persona)
                // Si no hi ha cap persona, Exception.
                // Execució
                // Mostrar per pantalla les dades de la persona actualment emmagatzemada a l'estat des de IPersona.
                break;
            case 2:
                Console.WriteLine("Has seleccionat l'opció 2: Convertir Persona a JSON");
                // Validacions
                // Comprovar que hi hagi una persona informada abans de convertir a JSON (EstatPersona == PossiblesEstatsPersona.Persona)
                // Si no hi ha cap persona, Exception.
                var hiHaPersona = Estat.EstatPersona == Estat.PossiblesEstatsPersona.Persona;
                if (!hiHaPersona) throw new Exception("No hi ha persona informada");

                // Execució
                // Convertir la persona actualment emmagatzemada a l'estat a format JSON i emmagatzemar el resultat a Estat.Cadena.
                // Actualitzar EstatCadena = PossiblesEstatsCadena.Json.
                var conversor = new Persona2Json();
                Estat.Cadena = conversor.ConverteixAjson(Estat.Persona!);
                Estat.EstatCadena = Estat.PossiblesEstatsCadena.Json;
                break;
            case 3:
                Console.WriteLine("Has seleccionat l'opció 3: Convertir Persona a XML");
                // Validacions
                // Comprovar que hi hagi una persona informada abans de convertir a XML (EstatPersona == PossiblesEstatsPersona.Persona)
                // Si no hi ha cap persona, Exception.
                // Execució
                // Convertir la persona actualment emmagatzemada a l'estat a format XML i emmagatzemar el resultat a Estat.Cadena.
                // Actualitzar EstatCadena = PossiblesEstatsCadena.Xml.
                break;
            case 4:
                Console.WriteLine("Has seleccionat l'opció 4: Convertir JSON a Persona");
                // Validacions
                // Comprovar que hi hagi una cadena JSON informada abans de convertir (EstatCadena == PossiblesEstatsCadena.Json)
                // Si no hi ha cap cadena JSON, Exception.
                // Execució
                // Deserialitzar la cadena JSON emmagatzemada a Estat.Cadena dins Estat.Persona.
                // Actualitzar EstatPersona = PossiblesEstatsPersona.Persona.
                break;
            case 5:
                Console.WriteLine("Has seleccionat l'opció 5: Convertir XML a Persona");
                // Validacions
                // Comprovar que hi hagi una cadena XML informada abans de convertir (EstatCadena == PossiblesEstatsCadena.Xml)
                // Si no hi ha cap cadena XML, Exception.
                // Execució
                // Deserialitzar la cadena XML emmagatzemada a Estat.Cadena dins Estat.Persona.
                // Actualitzar EstatPersona = PossiblesEstatsPersona.Persona.
                break;
            case 6:
                Console.WriteLine("Has seleccionat l'opció 6: Persistir cadena JSON a disc");
                // Validacions
                // Comprovar que hi hagi una cadena JSON informada (EstatCadena == PossiblesEstatsCadena.Json)
                // Si no hi ha cap cadena JSON, Exception.
                // Execució
                // Persistir la cadena JSON a disc.
                break;
            case 7:
                Console.WriteLine("Has seleccionat l'opció 7: Llegir cadena JSON des de disc");
                // Validacions
                // Comprovar que el fitxer existeix i és accessible.
                // Execució
                // Llegir la cadena JSON des de disc i emmagatzemar-la a Estat.Cadena.
                // Actualitzar EstatCadena = PossiblesEstatsCadena.Json.
                break;
            case 8:
                Console.WriteLine("Has seleccionat l'opció 8: Persistir cadena XML a disc");
                // Validacions
                // Comprovar que hi hagi una cadena XML informada (EstatCadena == PossiblesEstatsCadena.Xml)
                // Si no hi ha cap cadena XML, Exception.
                // Execució
                // Persistir la cadena XML a disc.
                break;
            case 9:
                Console.WriteLine("Has seleccionat l'opció 9: Llegir cadena XML des de disc");
                // Validacions
                // Comprovar que el fitxer existeix i és accessible.
                // Execució
                // Llegir la cadena XML des de disc i emmagatzemar-la a Estat.Cadena.
                // Actualitzar EstatCadena = PossiblesEstatsCadena.Xml.
                break;
            case 10:
                Console.WriteLine("Has seleccionat l'opció 10: Mostrar cadena");
                // Validacions
                // Comprovar que hi hagi una cadena informada (Estat.Cadena != null)
                // Si no hi ha cap cadena, Exception.
                // Execució
                // Mostrar per pantalla la cadena emmagatzemada a Estat.Cadena.
                var hiHaCadenaInformada = Estat.EstatCadena != Estat.PossiblesEstatsCadena.Buit;
                if (!hiHaCadenaInformada) throw new Exception("No hi ha cadena inforada");
                Console.WriteLine(Estat.Cadena);
                break;
            case 11:
                Console.WriteLine("Has seleccionat l'opció 11: Sortir");
                // Execució
                // Finalitzar el programa o sortir del bucle principal.
                break;
            default:
                Console.WriteLine("Opció no vàlida. Torna-ho a intentar.");
                break;
        }
    }
}