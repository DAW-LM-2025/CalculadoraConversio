namespace Conversors;
using Conversors.Abstract;
using System.Text.Json;

public class Persona2Json : IPersona2Json
{
    public string ConverteixAjson(Persona persona)
    {
        return JsonSerializer.Serialize(persona);
    }
}