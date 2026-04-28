namespace Conversors;
using Conversors.Abstract;
using System.Text.Json;

public class Json2Persona : IJson2Persona
{
    public Persona ConverteixApersona(string json)
    {
        var resultat = 
            JsonSerializer.Deserialize<Persona>(json) 
            ?? throw new Exception("No hem pogut deserialitzar la persona");
        return resultat;
    }
}