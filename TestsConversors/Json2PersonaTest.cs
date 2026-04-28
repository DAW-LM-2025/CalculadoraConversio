namespace TestsConversors;
using Conversors;
using Conversors.Abstract;

public class Json2PersonaTest
{
    [Fact]
    public void PucConvertirUnJsonApersona()
    {
        // Arrange // Given
        var json = """
        {
            "Nombre": "Dani 🤘",
            "Edat": 18,
            "Hobbies": ["Programar", "Leer", "Prison Break"],
            "Adreça": 
                {
                    "Carrer": "Hopl",
                    "Ciutat": "L'escala",
                    "Pais": "Alt Empordà"
                }
        }
        """;

        IJson2Persona conversor = new Json2Persona(); // TODO: Crear una instancia de la clase que implementa IPersona2Json

        // Act // When
        var persona = conversor.ConverteixApersona(json);

        // Assert // Then
        Assert.NotNull(persona);
        Assert.Equal("Dani 🤘", persona.Nombre);
        Assert.Contains("Programar", persona.Hobbies);
       
    }
}
