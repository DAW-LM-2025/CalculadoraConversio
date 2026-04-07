namespace TestsConversors;
using Conversors;
using Conversors.Abstract;

public class UnitTest1
{
    [Fact]
    public void PucConvertirPersonaAJson()
    {
        // Arrange
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
        IPersona2Json conversor = default!; // TODO: Crear una instancia de la clase que implementa IPersona2Json

        // Act
        var json = conversor.ConverteixAjson(persona);

        // Assert
        Assert.NotNull(json);
        Assert.StartsWith("{", json);
        Assert.EndsWith("}", json);
    }
}
