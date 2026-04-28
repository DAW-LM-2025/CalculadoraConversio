namespace TestsConversors;
using Conversors;
using Conversors.Abstract;

public class UnitTest1
{
    [Fact]
    public void PucConvertirPersonaAJson()
    {
        // Arrange // Given
        Persona persona = new ()
        {
            Nombre = "Dani",
            Edad = 30,
            Hobbies = ["Programar", "Correr"],
            Adreça = new Adreça
            {
                Carrer = "Calle Falsa 123",
                Ciutat = "Springfield",
                País = "USA"
            }
        };
        IPersona2Json conversor = new Persona2Json(); // TODO: Crear una instancia de la clase que implementa IPersona2Json

        // Act // When
        var json = conversor.ConverteixAjson(persona);

        // Assert // Then
        Assert.NotNull(json);
        Assert.StartsWith("{", json);
        Assert.EndsWith("}", json);
        Assert.Contains("\"Hobbies\":", json);
    }
}
