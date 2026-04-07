namespace Conversors;

public class Adreça
{
    public string Carrer { get; set; } = default!;
    public string Ciutat { get; set; } = default!;
    public string País { get; set; } = default!;
}

public class Persona
{
    public string Nombre { get; set; } = default!;
    public int Edad { get; set; }
    public List<string> Hobbies { get; set; } = default!;
    public Adreça Adreça { get; set; } = default!;
}


