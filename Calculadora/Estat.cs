namespace Calculadora;

using Conversors;

public class Estat
{
    public enum PossiblesEstatsCadena
    {
        Json,
        Xml,
        Buit
    }
    public enum PossiblesEstatsPersona
    {
        Persona,
        Buit
    }
    public string? Cadena { get; set; }
    public Persona? Persona { get; set; }
    public PossiblesEstatsCadena EstatCadena { get; set; } = PossiblesEstatsCadena.Buit;
    public PossiblesEstatsPersona EstatPersona { get; set; } = PossiblesEstatsPersona.Buit;
}
